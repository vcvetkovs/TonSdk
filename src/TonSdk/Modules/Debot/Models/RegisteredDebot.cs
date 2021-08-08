namespace TonSdk.Modules.Debot.Models
{
    /// <summary>
    ///     Structure for storing debot handle returned from
    ///     <see cref="IDebotModule.Start(ParamsOfStart)"/>
    ///     and <see cref="IDebotModule.Fetch(ParamsOfFetch)"/>
    ///     functions.
    /// </summary>
	public struct RegisteredDebot
    {
        /// <summary>
        ///     Debot handle which references an instance of debot engine.
        /// </summary>
        public uint DebotHandle { get; set; }

        /// <summary>
        ///     Debot abi as json string.
        /// </summary>
        public string DebotAbi { get; set; }

        /// <summary>
        ///     Debot metadata.
        /// </summary>
        public DebotInfo Info { get; set; }
    }
}
