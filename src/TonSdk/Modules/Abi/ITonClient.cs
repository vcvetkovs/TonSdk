using TonSdk.Modules.Abi;

namespace TonSdk
{
    public partial interface ITonClient
    {
        IAbiModule Abi { get; set; }
    }
}
