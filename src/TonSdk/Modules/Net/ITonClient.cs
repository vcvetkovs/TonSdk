using TonSdk.Modules.Net;

namespace TonSdk
{
    public partial interface ITonClient
    {
        INetModule Net { get; set; }
    }
}
