namespace EverscaleSdk.Modules.Boc.Models
{
    public struct ResultOfEncodeTvc
    {
        /// <summary>
        ///     Contract TVC image BOC encoded as base64 
        ///     or BOC handle of boc_cache parameter was specified.
        /// </summary>
        public string Tvc { get; set; }
    }
}
