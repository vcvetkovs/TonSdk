namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfModularPower
    {
        /// <summary>
        /// `base` argument of calculation.
        /// </summary>
        public string Base { get; set; }

        /// <summary>
        /// `exponent` argument of calculation.
        /// </summary>
        public string Exponent { get; set; }

        /// <summary>
        /// `modulus` argument of calculation.
        /// </summary>
        public string Modulus { get; set; }
    }
}
