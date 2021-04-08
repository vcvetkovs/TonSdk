namespace TonSdk.Modules.Boc.Models
{
    public struct ParamsOfParseShardState
    {
        /// <summary>
        /// BOC encoded as base64
        /// </summary>
        public string Boc { get; set; }

        /// <summary>
        /// Shardstate identificator
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Workchain shardstate belongs to
        /// </summary>
        public int WorkchainId { get; set; }
    }
}
