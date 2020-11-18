namespace TonSdk.Modules.Crypto.Models
{
    public struct ResultOfFactorize
    {
        /// <summary>
        /// Two factors of composite or empty if composite can't be factorized.
        /// </summary>
        public string[] Factors { get; set; }
    }
}
