using TonSdk.Modules.Client;

namespace TonSdk
{
    public partial interface ITonClient
    {
        IClientModule Client { get; set; }
    }
}
