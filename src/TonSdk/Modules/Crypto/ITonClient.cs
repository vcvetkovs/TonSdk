using TonSdk.Modules.Crypto;

namespace TonSdk
{
    public partial interface ITonClient
    {
        ICryptoModule Crypto { get; set; }
    }
}
