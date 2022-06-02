namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ParamsOfModularPower
    {
        /// <summary>
        ///     <c>base</c> argument of calculation.
        /// </summary>
        public string Base { get; set; }

        /// <summary>
        ///     <c>exponent</c> argument of calculation.
        /// </summary>
        public string Exponent { get; set; }

        /// <summary>
        ///     <c>modulus</c> argument of calculation.
        /// </summary>
        public string Modulus { get; set; }
    }
}
