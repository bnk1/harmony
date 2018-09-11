using HarmonyHub;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HarmonyDemo
{
    public partial class FormHarmonyDemo : Form
    {
        RichTextBoxTraceListener iLogsTraceListener;
        HarmonyTraceListener iHarmonTraceListener;

        public FormHarmonyDemo()
        {
            InitializeComponent();

            //Redirect traces
            iLogsTraceListener = new RichTextBoxTraceListener(richTextBoxLogs);
            iHarmonTraceListener = new HarmonyTraceListener(toolStripStatusLabelConnection);

            richTextBoxLogs.TextChanged += RichTextBoxLogs_TextChanged;
        }

        private void RichTextBoxLogs_TextChanged(object sender, EventArgs e)
        {
            richTextBoxLogs.SelectionStart = richTextBoxLogs.Text.Length;
            richTextBoxLogs.ScrollToCaret();
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                // ConnectAsync already if we have an existing session cookie
                if (File.Exists("SessionToken"))
                {
                    await HarmonyConnectAsync();
                }
            }
            catch
            {
                
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task HarmonyOpenAsync()
        {
            try
            {
                //Create client if it does not already exists or the hub address has changed
                if (Program.Client == null || !Program.Client.Host.Equals(textBoxHarmonyHubAddress.Text))
                {
                    Program.Client = new HarmonyClient(textBoxHarmonyHubAddress.Text, checkBoxKeepAlive.Checked);
                    Program.Client.OnTaskChanged += TaskChangedHandler;
                    Program.Client.OnConnectionClosed += ConnectionClosedHandler;
                }

                //First create our client and login
                if (File.Exists("SessionToken"))
                {
                    var sessionToken = File.ReadAllText("SessionToken");
                    Trace.WriteLine("Reusing token: " + sessionToken);
                    toolStripStatusLabelConnection.Text += $"Reusing token: {sessionToken}";
                    await Program.Client.TryOpenAsync(sessionToken);
                }
                else
                {
                    await Program.Client.TryOpenAsync();
                    File.WriteAllText("SessionToken", Program.Client.Token);
                }
            }
            catch
            {
                
            }
        }

        /// <summary>
        /// Display our client status
        /// </summary>
        /// <param name="aSender"></param>
        /// <param name="aRequestPending"></param>
        void TaskChangedHandler(object aSender, bool aRequestPending)
        {
            try
            {
                // Consistency check
                Debug.Assert(aRequestPending == Program.Client.RequestPending);

                toolStripStatusLabelRequest.Text = "";

                // Display request status
                if (aRequestPending)
                {
                    toolStripStatusLabelRequest.Text = "Busy - ";
                }
                else if (Program.Client.IsOpen)
                {
                    toolStripStatusLabelRequest.Text = "Open - ";
                }
                else if (Program.Client.IsClosed)
                {
                    toolStripStatusLabelRequest.Text = "Closed - ";
                }

                toolStripStatusLabelRequest.Text += aRequestPending ? "Request pending" : "Request completed";
            }
            catch
            {
                
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aSender"></param>
        /// <param name="aRequestWasCancelled"></param>
        void ConnectionClosedHandler(object aSender, bool aClosedByServer)
        {
            try
            {
                // Consistency check
                //Debug.Assert(Program.Client.IsClosed);

                // We know this notification is not coming from the UI thread.
                // Therefore we Invoke to be able to modifiy our tree view control.
                // Try opening our connection again to keep it alive.
                if (aClosedByServer)
                {
                    //Server closed our connection try reconnect then
                    BeginInvoke(new MethodInvoker(async delegate () { await HarmonyConnectAsync(); }));

                }
                else
                {
                    // Just clear our config
                    BeginInvoke(new MethodInvoker(delegate () { ClearConfig(); }));
                }
            }
            catch
            {
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        void ClearConfig()
        {
            treeViewConfig.Nodes.Clear();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task HarmonyConnectAsync()
        {
            treeViewConfig.Nodes.Clear();

            await HarmonyOpenAsync();

            //Added if statement to make sure "Missing credential" status remains if needed
            if (Program.Client.IsReady)
            {
                await HarmonyGetConfigAsync();
            }            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task HarmonyGetConfigAsync()
        {
            //Fetch our config
            var harmonyConfig = await Program.Client.GetConfigAsync();
            if (harmonyConfig == null)
            {
                return;
            }
            PopulateTreeViewConfig(harmonyConfig);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aConfig"></param>
        private void PopulateTreeViewConfig(Config aConfig)
        {
            treeViewConfig.Nodes.Clear();
            //Add our devices
            foreach (Device device in aConfig.Devices)
            {
                TreeNode deviceNode = treeViewConfig.Nodes.Add(device.Id, $"{device.Label} ({device.DeviceTypeDisplayName}/{device.Model}) ({device.Id})");

                deviceNode.Tag = device;

                foreach (ControlGroup cg in device.ControlGroups)
                {
                    TreeNode cgNode = deviceNode.Nodes.Add(cg.Name);
                    cgNode.Tag = cg;

                    foreach (Function f in cg.Functions)
                    {
                        TreeNode fNode = cgNode.Nodes.Add(f.Action.Command);
                        fNode.Tag = f;
                    }
                }
            }

            //treeViewConfig.ExpandAll();
        }


        private async void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.HarmonyHubAddress = textBoxHarmonyHubAddress.Text;
            Properties.Settings.Default.Save();

            try
            {             //Closing properly
                await Program.Client.CloseAsync();
            }
            catch
            {

            }
        }

        private async void buttonClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.Client != null)
                {
                    await Program.Client.CloseAsync();
                }
                treeViewConfig.Nodes.Clear();
            }
            catch
            {

            }
        }

        private void buttonDeleteToken_Click(object sender, EventArgs e)
        {
            File.Delete("SessionToken");
        }


        private async void treeViewConfig_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Upon function node double click we execute it
            var tag = e.Node.Tag as Function;

            if (tag != null && e.Node.Parent.Parent.Tag is Device)
            {
                Function f = tag;
                Device d = (Device)e.Node.Parent.Parent.Tag;

                toolStripStatusLabelConnection.Text = $"Sending {f.Name} to {d.Label}...";

                await Program.Client.TrySendKeyPressAsync(d.Id, f.Action.Command);
            }
        }

        private async void buttonOpen_Click(object sender, EventArgs e)
        {
            await HarmonyOpenAsync();
        }

        private async void buttonConnect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();

            try
            {
                await HarmonyConnectAsync();
            }
            catch
            {

            }
        }

        private async void buttonConfig_Click(object sender, EventArgs e)
        {
            try
            {
                await HarmonyGetConfigAsync();
            }
            catch
            {

            }
        }

        /// <summary>
        /// We don't disable buttons ATM thus we can stress test our APIs.
        /// </summary>
        private void DisableButtons()
        {
            buttonClose.Enabled = false;
            buttonOpen.Enabled = false;
            buttonConnect.Enabled = false;
            buttonConfig.Enabled = false;
        }

        private void buttonClearLogs_Click(object sender, EventArgs e)
        {
            richTextBoxLogs.Clear();
        }

        private async void checkBoxKeepAlive_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Closing properly
                if (Program.Client != null)
                {
                    await Program.Client.CloseAsync();
                }
                //We need to re-create our client
                Program.Client = null;
                await HarmonyConnectAsync();
            }
            catch
            {

            }
        }

        private void treeViewConfig_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var tag = e.Node.Tag as Function;

            if (tag != null && e.Node.Parent.Parent.Tag is Device)
            {
                Function f = tag;
                Device d = (Device)e.Node.Parent.Parent.Tag;

                tspLabelCmdDesc.Text = $"Device: {d.Id} Cmd: {f.Action.Command}";

                richTextBoxCmd.Text = HarmonyClient.GetPressCmd(d.Id, f.Action.Command);
            }
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void WriteLine(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
