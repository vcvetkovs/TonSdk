namespace TonSdk.Modules.Processing.Models
{
    public struct ResultOfSendMessage
    {
        /// <summary>
        /// The last generated shard block of the message destination account before the
        /// message was sent.
        /// 
        /// This block id must be used as a parameter of the
        /// `wait_for_transaction`.
        /// </summary>
        public string ShardBlockId { get; set; }
    }
}
