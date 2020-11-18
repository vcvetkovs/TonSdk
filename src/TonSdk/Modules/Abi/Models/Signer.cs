using TonSdk.Modules.Abi.Enums;
using TonSdk.Modules.Crypto.Models;

namespace TonSdk.Modules.Abi.Models
{
    public struct SignerNone 
    {
        public SignerType Type => SignerType.None;
    }

    public struct SignerExternal
    {
        public string PublicKey { get; set; }
        public SignerType Type => SignerType.External;
    }

    public struct SignerKeys
    {
        public KeyPair Keys { get; set; }
        public SignerType Type => SignerType.Keys;
    }

    public struct SignerSigningBox
    {
        public uint Handle { get; set; }
        public SignerType Type => SignerType.SigningBox;
    }
}
