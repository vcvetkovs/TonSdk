using EverscaleSdk.Modules.Processing;

namespace EverscaleSdk
{
    public partial interface IEverscaleClient
    {
        IProcessingModule Processing { get; set; }
    }
}
