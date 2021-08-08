namespace TonSdk.Modules.Net.Models
{
    public struct ResultOfSubscribeCollection
    {
        /// <summary>
        ///     Subscription handle.
        ///     Must be closed with <c>unsubscribe</c> (it is done automatically).
        /// </summary>
        public uint Handle { get; set; }
    }
}
