using EverscaleSdk.Modules.Net.Enums;

namespace EverscaleSdk.Modules.Net.Models
{
    public struct OrderBy
    {
        public string Path { get; set; }
        public SortDirection Direction { get; set; }
    }
}
