namespace EverscaleSdk.Modules.Abi.Models
{
    public struct AbiData
    {
        public ulong Key { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public AbiParameter[] Components { get; set; }
    }
}
