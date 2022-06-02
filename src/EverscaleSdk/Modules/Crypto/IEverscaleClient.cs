using EverscaleSdk.Modules.Crypto;

namespace EverscaleSdk
{
    public partial interface IEverscaleClient
    {
        ICryptoModule Crypto { get; set; }
    }
}
