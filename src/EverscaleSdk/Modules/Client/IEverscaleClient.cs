using EverscaleSdk.Modules.Client;

namespace EverscaleSdk
{
    public partial interface IEverscaleClient
    {
        IClientModule Client { get; set; }
    }
}
