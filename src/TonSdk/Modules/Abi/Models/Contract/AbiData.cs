namespace TonSdk.Modules.Abi.Models
{
    public class AbiData
    {
        public ulong Key { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public AbiParameter[] Components { get; set; }
    }
}
