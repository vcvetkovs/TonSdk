namespace TonSdk.Modules.Net.Models
{
    public struct ResultOfSubscribeCollection
    {
        /// <summary>
        /// Subscription handle. Must be closed with `unsubscribe`.
        /// </summary>
        public uint Handle { get; set; }
    }
}
