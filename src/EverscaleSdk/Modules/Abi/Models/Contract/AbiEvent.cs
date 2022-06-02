namespace EverscaleSdk.Modules.Abi.Models
{
    public struct AbiEvent
    {
        public string Name { get; set; }

        public AbiParameter[] Inputs { get; set; }

        public string? Id { get; set; }
    }
}
