using TonSdk.Modules.Utils;

namespace TonSdk
{
    public partial interface ITonClient
    {
        IUtilsModule Utils { get; set; }
    }
}
