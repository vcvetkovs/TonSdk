namespace EverscaleSdk.Modules.Abi.Models
{
    public struct AbiFunction
    {
        public string Name { get; set; }

        public AbiParameter[] Inputs { get; set; }

        public AbiParameter[] Outputs { get; set; }

        public string? Id { get; set; }
    }
}
