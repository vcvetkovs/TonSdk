using TonSdk.Modules.Boc;

namespace TonSdk
{
    public partial interface ITonClient
    {
        IBocModule Boc { get; set; }
    }
}
