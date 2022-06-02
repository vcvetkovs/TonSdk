namespace EverscaleSdk.Modules.Abi.Models
{
    public struct AbiParameter
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public AbiParameter[] Components { get; set; }
    }
}
