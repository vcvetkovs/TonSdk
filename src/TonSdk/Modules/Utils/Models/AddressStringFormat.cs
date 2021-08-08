namespace TonSdk.Modules.Utils.Models
{
    public abstract class AddressStringFormat
    {
        public class AccountId : AddressStringFormat
        {
        }

        public class Hex : AddressStringFormat
        {
        }

        public class Base64 : AddressStringFormat
        {
            public bool Url { get; set; }

            public bool Test { get; set; }

            public bool Bounce { get; set; }
        }
    }
}
