namespace TonSdk.Modules.Abi.Enums
{
    public enum StateInitSource
    {
        /// <summary>
        /// Deploy message.
        /// </summary>
        Message,

        /// <summary>
        /// State init data.
        /// </summary>
        StateInit,

        /// <summary>
        /// Content of the TVC file. Encoded in `base64`.
        /// </summary>
        Tvc
    }
}
