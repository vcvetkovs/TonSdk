namespace EverscaleSdk.Modules.Proofs.Models
{
	public struct ParamsOfProofBlockData
    {
        /// <summary>
        ///     Single block's data, retrieved from TONOS API, that needs proof.
        ///     Required fields are <c>id</c> and/or top-level <c>boc</c> (for block identification), others are optional.
        /// </summary>
        public dynamic? Block { get; set; }
    }
}
