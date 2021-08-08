namespace TonSdk.Modules.Abi.Models
{
    public class AbiFunction
    {
        public string Name { get; set; }

        public AbiParameter[] Inputs { get; set; }

        public AbiParameter[] Outputs { get; set; }

        public string? Id { get; set; }
    }
}
