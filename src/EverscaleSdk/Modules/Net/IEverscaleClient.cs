using EverscaleSdk.Modules.Net;

namespace EverscaleSdk
{
    public partial interface IEverscaleClient
    {
        INetModule Net { get; set; }
    }
}
