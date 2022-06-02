namespace EverscaleSdk.Modules.Debot.Models
{
    /// <summary>
    ///     DeBot metadata.
    /// </summary>
    public struct DebotInfo
    {
        /// <summary>
        ///     DeBot short name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     DeBot semantic version.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        ///     The name of DeBot deployer.
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        ///     Short info about DeBot.
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        ///     The name of DeBot developer.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        ///     TON address of author for questions and donations.
        /// </summary>
        public string Support { get; set; }

        /// <summary>
        ///     String with the first messsage from DeBot.
        /// </summary>
        public string Hello { get; set; }

        /// <summary>
        ///     String with DeBot interface language (ISO-639).
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        ///     String with DeBot ABI.
        /// </summary>
        public string Dabi { get; set; }

        /// <summary>
        ///     DeBot icon.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        ///     Vector with IDs of DInterfaces used by DeBot.
        /// </summary>
        public string[] Interfaces { get; set; }

        /// <summary>
        ///     ABI version ("x.y") supported by DeBot.
        /// </summary>
        public string DabiVersion { get; set; }
    }
}
