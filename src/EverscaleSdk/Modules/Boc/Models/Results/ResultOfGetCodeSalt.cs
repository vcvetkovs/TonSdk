namespace EverscaleSdk.Modules.Boc.Models
{
    public struct ResultOfGetCodeSalt
    {
        /// <summary>
        ///     BOC encoded as base64 or BOC handle.
        /// </summary>
        public string Salt { get; set; }
    }
}
