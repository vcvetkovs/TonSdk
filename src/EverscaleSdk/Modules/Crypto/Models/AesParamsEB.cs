using System.Security.Cryptography;

namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct AesParamsEB
    {
        public CipherMode Mode { get; set; }

        public string Key { get; set; }

        public string Iv { get; set; }
    }
}
