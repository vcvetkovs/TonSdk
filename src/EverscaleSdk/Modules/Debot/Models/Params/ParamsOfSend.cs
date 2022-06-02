namespace EverscaleSdk.Modules.Debot.Models
{
    /// <summary>
    ///     Parameters of `send` function.
    /// </summary>
    public struct ParamsOfSend
    {
        /// <summary>
        ///     Debot handle which references an instance of debot engine.
        /// </summary>
        public uint DebotHandle { get; set; }

        /// <summary>
        ///     BOC of internal message to debot encoded in base64 format.
        /// </summary>
        public string Message { get; set; }
    }
}
