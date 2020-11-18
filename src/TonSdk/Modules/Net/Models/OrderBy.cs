using TonSdk.Modules.Net.Enums;

namespace TonSdk.Modules.Net.Models
{
    public struct OrderBy
    {
        public string Path { get; set; }
        public SortDirection Direction { get; set; }
    }
}
