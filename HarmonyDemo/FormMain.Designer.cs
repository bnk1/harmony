namespace HarmonyDemo
{
    partial class FormHarmonyDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch
            {

            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHarmonyDemo));
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRequest = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageHarmony = new System.Windows.Forms.TabPage();
            this.richTextBoxCmd = new System.Windows.Forms.RichTextBox();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDeleteToken = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewConfig = new System.Windows.Forms.TreeView();
            this.richTextBoxLogs = new System.Windows.Forms.RichTextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxKeepAlive = new System.Windows.Forms.CheckBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxHarmonyHubAddress = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspLabelCmdDesc = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspCmd = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageHarmony.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Harmony Hub Address:";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConnection,
            this.toolStripStatusLabelSpring,
            this.toolStripStatusLabelRequest});
            this.statusStrip.Location = new System.Drawing.Point(0, 557);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1015, 22);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "App Status";
            // 
            // toolStripStatusLabelConnection
            // 
            this.toolStripStatusLabelConnection.Name = "toolStripStatusLabelConnection";
            this.toolStripStatusLabelConnection.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatusLabelConnection.Text = "Connection Status";
            // 
            // toolStripStatusLabelSpring
            // 
            this.toolStripStatusLabelSpring.Name = "toolStripStatusLabelSpring";
            this.toolStripStatusLabelSpring.Size = new System.Drawing.Size(812, 17);
            this.toolStripStatusLabelSpring.Spring = true;
            // 
            // toolStripStatusLabelRequest
            // 
            this.toolStripStatusLabelRequest.Name = "toolStripStatusLabelRequest";
            this.toolStripStatusLabelRequest.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabelRequest.Text = "Request Status";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageHarmony);
            this.tabControlMain.Location = new System.Drawing.Point(12, 64);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(991, 473);
            this.tabControlMain.TabIndex = 11;
            // 
            // tabPageHarmony
            // 
            this.tabPageHarmony.Controls.Add(this.richTextBoxCmd);
            this.tabPageHarmony.Controls.Add(this.buttonConfig);
            this.tabPageHarmony.Controls.Add(this.buttonConnect);
            this.tabPageHarmony.Controls.Add(this.buttonDeleteToken);
            this.tabPageHarmony.Controls.Add(this.buttonClose);
            this.tabPageHarmony.Controls.Add(this.buttonOpen);
            this.tabPageHarmony.Controls.Add(this.splitContainer1);
            this.tabPageHarmony.Location = new System.Drawing.Point(4, 22);
            this.tabPageHarmony.Name = "tabPageHarmony";
            this.tabPageHarmony.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHarmony.Size = new System.Drawing.Size(983, 447);
            this.tabPageHarmony.TabIndex = 0;
            this.tabPageHarmony.Text = "Harmony";
            this.tabPageHarmony.UseVisualStyleBackColor = true;
            // 
            // richTextBoxCmd
            // 
            this.richTextBoxCmd.Location = new System.Drawing.Point(122, 394);
            this.richTextBoxCmd.Name = "richTextBoxCmd";
            this.richTextBoxCmd.Size = new System.Drawing.Size(636, 47);
            this.richTextBoxCmd.TabIndex = 19;
            this.richTextBoxCmd.Text = "";
            // 
            // buttonConfig
            // 
            this.buttonConfig.Location = new System.Drawing.Point(6, 93);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(101, 23);
            this.buttonConfig.TabIndex = 16;
            this.buttonConfig.Text = "Config";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(6, 6);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(101, 23);
            this.buttonConnect.TabIndex = 15;
            this.buttonConnect.Text = "Connect";
            this.toolTip.SetToolTip(this.buttonConnect, "Open and get config");
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDeleteToken
            // 
            this.buttonDeleteToken.Location = new System.Drawing.Point(6, 122);
            this.buttonDeleteToken.Name = "buttonDeleteToken";
            this.buttonDeleteToken.Size = new System.Drawing.Size(101, 23);
            this.buttonDeleteToken.TabIndex = 14;
            this.buttonDeleteToken.Text = "Delete Token";
            this.buttonDeleteToken.UseVisualStyleBackColor = true;
            this.buttonDeleteToken.Click += new System.EventHandler(this.buttonDeleteToken_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(6, 64);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(101, 23);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(6, 35);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(101, 23);
            this.buttonOpen.TabIndex = 11;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(122, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewConfig);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxLogs);
            this.splitContainer1.Size = new System.Drawing.Size(861, 384);
            this.splitContainer1.SplitterDistance = 636;
            this.splitContainer1.TabIndex = 18;
            // 
            // treeViewConfig
            // 
            this.treeViewConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewConfig.Location = new System.Drawing.Point(0, 0);
            this.treeViewConfig.Name = "treeViewConfig";
            this.treeViewConfig.Size = new System.Drawing.Size(636, 384);
            this.treeViewConfig.TabIndex = 12;
            this.treeViewConfig.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewConfig_NodeMouseClick);
            this.treeViewConfig.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewConfig_NodeMouseDoubleClick);
            // 
            // richTextBoxLogs
            // 
            this.richTextBoxLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxLogs.DetectUrls = false;
            this.richTextBoxLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLogs.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLogs.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxLogs.Name = "richTextBoxLogs";
            this.richTextBoxLogs.ReadOnly = true;
            this.richTextBoxLogs.Size = new System.Drawing.Size(221, 384);
            this.richTextBoxLogs.TabIndex = 17;
            this.richTextBoxLogs.Text = "";
            this.richTextBoxLogs.WordWrap = false;
            // 
            // checkBoxKeepAlive
            // 
            this.checkBoxKeepAlive.AutoSize = true;
            this.checkBoxKeepAlive.Location = new System.Drawing.Point(923, 40);
            this.checkBoxKeepAlive.Name = "checkBoxKeepAlive";
            this.checkBoxKeepAlive.Size = new System.Drawing.Size(76, 17);
            this.checkBoxKeepAlive.TabIndex = 12;
            this.checkBoxKeepAlive.Text = "Keep alive";
            this.checkBoxKeepAlive.UseVisualStyleBackColor = true;
            this.checkBoxKeepAlive.CheckedChanged += new System.EventHandler(this.checkBoxKeepAlive_CheckedChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(154, 22);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 14;
            this.labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HarmonyDemo.Properties.Settings.Default, "LogitechUserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxUsername.Location = new System.Drawing.Point(154, 38);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(219, 20);
            this.textBoxUsername.TabIndex = 13;
            this.textBoxUsername.Text = global::HarmonyDemo.Properties.Settings.Default.LogitechUsername;
            // 
            // textBoxHarmonyHubAddress
            // 
            this.textBoxHarmonyHubAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HarmonyDemo.Properties.Settings.Default, "HarmonyHubAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxHarmonyHubAddress.Location = new System.Drawing.Point(35, 38);
            this.textBoxHarmonyHubAddress.Name = "textBoxHarmonyHubAddress";
            this.textBoxHarmonyHubAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxHarmonyHubAddress.TabIndex = 0;
            this.textBoxHarmonyHubAddress.Text = global::HarmonyDemo.Properties.Settings.Default.HarmonyHubAddress;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HarmonyDemo.Properties.Settings.Default, "LogitechPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPassword.Location = new System.Drawing.Point(379, 38);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(126, 20);
            this.textBoxPassword.TabIndex = 15;
            this.textBoxPassword.Text = global::HarmonyDemo.Properties.Settings.Default.LogitechPassword;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(376, 22);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Password";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tspLabelCmdDesc,
            this.toolStripStatusLabel3,
            this.tspCmd,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1015, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "App Status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel1.Text = "Cmd:";
            // 
            // tspLabelCmdDesc
            // 
            this.tspLabelCmdDesc.AutoSize = false;
            this.tspLabelCmdDesc.Name = "tspLabelCmdDesc";
            this.tspLabelCmdDesc.Size = new System.Drawing.Size(250, 17);
            this.tspLabelCmdDesc.Text = "10000000 Power Off";
            this.tspLabelCmdDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // tspCmd
            // 
            this.tspCmd.Name = "tspCmd";
            this.tspCmd.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(714, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormHarmonyDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 579);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.checkBoxKeepAlive);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxHarmonyHubAddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHarmonyDemo";
            this.Text = "Harmony Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageHarmony.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHarmonyHubAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConnection;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageHarmony;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TreeView treeViewConfig;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDeleteToken;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSpring;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRequest;
        private System.Windows.Forms.CheckBox checkBoxKeepAlive;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.RichTextBox richTextBoxLogs;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tspLabelCmdDesc;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tspCmd;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.RichTextBox richTextBoxCmd;
    }
}

