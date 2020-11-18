namespace TonSdk.Modules.Tvm.Models
{
    public struct ExecutionOptions
    {
        // BOC with config
        public string? BlockchainConfig { get; set; }

        // Time that is used as transaction time
        public int? BlockTime { get; set; }

        // Block logical time
        public double? BlockLt { get; set; }

        // Transaction logical time
        public double? TransactionLt { get; set; }
    }
}
