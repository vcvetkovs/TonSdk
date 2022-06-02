using EverscaleSdk.Modules.Crypto.Enums;

namespace EverscaleSdk.Modules.Crypto
{
    public struct AesInfo
    {
        public CipherMode Mode { get; set; }

        public string Iv { get; set; }
    }
}
