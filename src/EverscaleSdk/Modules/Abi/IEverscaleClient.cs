using EverscaleSdk.Modules.Abi;

namespace EverscaleSdk
{
    public partial interface IEverscaleClient
    {
        IAbiModule Abi { get; set; }
    }
}
