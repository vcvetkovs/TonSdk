namespace TonSdk.Modules.Abi.Models
{
    /// <summary>
    ///     The ABI function header.
    /// </summary>
    /// <remarks>
    ///      Includes several hidden function parameters that contract
    ///      uses for security and replay protection reasons.
    ///  <para/>
    ///      The actual set of header fields depends on the contract's ABI.
    ///  <para/>
    ///      If a contract's ABI does not include some headers, then they are not filled.
    ///  <para/>
    /// </remarks>
    public struct FunctionHeader
    {
        /// <summary>
        ///     Message expiration time in seconds.
        /// </summary>
        /// <remarks>
        ///     If not specified - calculated automatically from
        ///     message_expiration_timeout(), try_index and message_expiration_timeout_grow_factor()
        ///     (if ABI includes <c>expire</c> header).
        /// </remarks>
        public uint? Expire { get; set; }

        /// <summary>
        ///     Message creation time in milliseconds.
        /// </summary>
        /// <remarks>
        ///     If not specified, <c>now</c> is used (if ABI includes <c>time</c> header).
        /// </remarks>
        public ulong? Time { get; set; }

        /// <summary>
        ///    Public key is used by the contract to check the signature.
        /// </summary>
        /// <remarks>
        ///     Encoded in <c>hex</c>. 
        ///  <para/>
        ///     If not specified, method fails with exception (if ABI includes <c>pubkey</c> header). 
        ///  <para/>
        /// </remarks>
        public string? Pubkey { get; set; }
    }
}
