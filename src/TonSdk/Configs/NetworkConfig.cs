namespace TonSdk.Configs
{
    public struct NetworkConfig
    {
        public string? ServerAddress { get; set; }
        public sbyte? NetworkRetriesCount { get; set; }
        public sbyte? MessageRetriesCount { get; set; }
        public uint? MessageProcessingTimeout { get; set; }
        public uint? WaitForTimeout { get; set; }
        public uint? OutOfSyncThreshold { get; set; }
        public string? AccessKey { get; set; }
    }
}
