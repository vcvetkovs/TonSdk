namespace TonSdk.Modules.Proofs
{
	public partial interface ITonClient
	{
        /// <summary>
        ///     [UNSTABLE](UNSTABLE.md) Module for proving data, retrieved from TONOS API.
        /// </summary>
        public IProofsModule Proofs { get; }
	}
}

