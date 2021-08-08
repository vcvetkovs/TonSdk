namespace TonSdk.Modules.Abi.Models
{
    public class AbiParameter
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public AbiParameter[] Components { get; set; }
    }
}
