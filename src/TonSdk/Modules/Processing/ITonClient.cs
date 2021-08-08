using TonSdk.Modules.Processing;

namespace TonSdk
{
    public partial interface ITonClient
    {
        IProcessingModule Processing { get; set; }
    }
}
