namespace TonSdk.Modules.Abi.Models
{
    public class AbiEvent
    {
        public string Name { get; set; }

        public AbiParameter[] Inputs { get; set; }

        public string? Id { get; set; }
    }
}
