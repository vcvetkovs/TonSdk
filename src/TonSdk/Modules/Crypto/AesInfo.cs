using TonSdk.Modules.Crypto.Enums;

namespace TonSdk.Modules.Crypto
{
    public struct AesInfo
    {
        public CipherMode Mode { get; set; }

        public string Iv { get; set; }
    }
}
