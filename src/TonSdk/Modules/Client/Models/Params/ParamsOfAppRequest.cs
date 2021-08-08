namespace TonSdk.Modules.Client.Models
{
	public struct ParamsOfAppRequest
    {
        /// <summary>
        ///     Should be used in <see cref="IClientModule.ResolveAppRequest(ParamsOfResolveAppRequest)"/> call.
        /// </summary>
        public uint AppRequestId { get; set; }

        /// <summary>
        ///     Request describing data.
        /// </summary>
        public dynamic RequestData { get; set; }
    }
}
