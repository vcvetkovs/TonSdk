using EverscaleSdk.Modules.Tvm;

namespace EverscaleSdk
{
    public partial interface IEverscaleClient
    {
        ITvmModule Tvm { get; set; }
    }
}
