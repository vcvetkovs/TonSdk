namespace TonSdk.Modules.Abi.Models
{
    public abstract class Abi
    {
        public class Contract : Abi
        {
            public AbiContract Value { get; set; }
        }

        public class Json : Abi
        {
            public string Value { get; set; }
        }

        public class Handle : Abi
        {
            public uint Value { get; set; }
        }

        public class Serialized : Abi
        {
            public AbiContract Value { get; set; }
        }
    }
}
