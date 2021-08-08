namespace TonSdk.Modules.Net.Models
{
    public struct ResultOfGetEndpoints
    {
        /// <summary>
        ///     Current query endpoint.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        ///     List of all endpoints used by client.
        /// </summary>
        public string[] Endpoints { get; set; }
    }
}
