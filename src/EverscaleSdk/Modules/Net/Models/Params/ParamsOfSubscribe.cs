namespace EverscaleSdk.Modules.Net.Models
{
    public struct ParamsOfSubscribe
    {
        /// <summary>
        ///     GraphQL subscription text.
        /// </summary>
        public string Subscription { get; set; }

        /// <summary>
        ///     Variables used in subscription.
        ///     Must be a map with named values that can be used in query.
        /// </summary>
        public dynamic? Variables { get; set; }
    }
}

