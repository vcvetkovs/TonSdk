using TonSdk.Modules.Tvm;

namespace TonSdk
{
    public partial interface ITonClient
    {
        ITvmModule Tvm { get; set; }
    }
}
