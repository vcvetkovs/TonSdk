namespace TonSdk.Modules.Abi.Models
{
    /// <summary>
    /// The ABI function header.
    /// 
    /// Includes several hidden function parameters that contract
    /// uses for security and replay protection reasons.
    /// 
    /// The actual set of header fields depends on the contract's ABI.
    /// </summary>
    public struct FunctionHeader
    {
        /// <summary>
        /// Message expiration time in seconds.
        /// </summary>
        public uint? Expire { get; set; }

        /// <summary>
        /// Message creation time in milliseconds.
        /// </summary>
        public ulong? Time { get; set; }

        /// <summary>
        /// Public key used to sign message. Encoded with `hex`.
        /// </summary>
        public string? Pubkey { get; set; }
    }
}
