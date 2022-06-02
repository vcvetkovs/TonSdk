namespace EverscaleSdk.Modules.Proofs
{
	public partial interface IEverscaleClient
	{
        /// <summary>
        ///     [UNSTABLE](UNSTABLE.md) Module for proving data, retrieved from TONOS API.
        /// </summary>
        public IProofsModule Proofs { get; }
	}
}

