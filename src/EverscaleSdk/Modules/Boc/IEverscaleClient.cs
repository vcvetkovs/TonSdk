using EverscaleSdk.Modules.Boc;

namespace EverscaleSdk
{
    public partial interface IEverscaleClient
    {
        IBocModule Boc { get; set; }
    }
}
