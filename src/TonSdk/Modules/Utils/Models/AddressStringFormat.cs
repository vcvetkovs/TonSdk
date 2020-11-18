using TonSdk.Modules.Utils.Enums;

namespace TonSdk.Modules.Utils.Models
{
    public struct AddressStringFormat
    {
        public AddressStringFormatType Type { get; set; }
        public bool Url { get; set; }
        public bool Test { get; set; }
        public bool Bounce { get; set; }
    }
}
