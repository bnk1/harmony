using System.Runtime.Serialization;

namespace HarmonyHub.Entities.Response
{
    /// <summary>
    /// TODO: Document this
    /// </summary>
    [DataContract]
    public class Function
    {
        /// <summary>
        /// Action object.
        /// </summary>
        [DataMember(Name = "action")]
        public HarmonyAction Action { get; set; }

        /// <summary>
        /// Label of this function as defined in your Harmony configuration.
        /// </summary>
        [DataMember(Name = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Name of this function as defined in your Harmony configuration.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// ToString will return the name of the function with the label behind it.
        /// </summary>
        public override string ToString()
        {
            return $"{Name} ({Label})";
        }
    }
}