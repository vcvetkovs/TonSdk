namespace TonSdk.Configs
{
    public struct AbiConfig
    {
        public int? Workchain { get; set; }
        public uint? MessageExpirationTimeout { get; set; }
        public float? MessageExpirationTimeoutGrowFactor { get; set; }
    }
}
