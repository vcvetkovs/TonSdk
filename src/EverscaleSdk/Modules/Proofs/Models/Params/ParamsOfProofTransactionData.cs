namespace EverscaleSdk.Modules.Proofs.Models
{
	public struct ParamsOfProofTransactionData
    {
        /// <summary>
        ///     Single transaction's data as queried from DApp server, without
        ///     modifications.
        ///     The required fields are <c>id</c> and/or top-level <c>boc</c>,
        ///     others are optional.
        ///     In order to reduce network requests count, it is recommended to
        ///     provide <c>block_id</c> and <c>boc</c> of transaction.
        /// </summary>
        public dynamic? Transaction { get; set; }
    }
}

