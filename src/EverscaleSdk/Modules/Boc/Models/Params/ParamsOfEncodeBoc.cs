namespace EverscaleSdk.Modules.Boc.Models
{
    public struct ParamsOfEncodeBoc
    {
		/// <summary>
		///		Cell builder operations.
		/// </summary>
		public BuilderOp[] Builder { get; set; }

		/// <summary>
		///		Cache type to put the result. <para/>
		///		
		///		The BOC itself returned if no cache type provided.
		/// </summary>
		public BocCacheType BocCache { get; set; }
	}
}
