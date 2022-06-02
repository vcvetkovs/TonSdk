using EverscaleSdk.Modules.Utils;

namespace EverscaleSdk
{
    public partial interface IEverscaleClient
    {
        IUtilsModule Utils { get; set; }
    }
}
