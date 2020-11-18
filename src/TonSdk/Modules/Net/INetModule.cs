using System.Threading.Tasks;
using TonSdk.Common;
using TonSdk.Modules.Net.Models;

namespace TonSdk.Modules.Net
{
    /// <summary>
    /// Network access.
    /// </summary>
    public interface INetModule
    {
        /// <summary>
        /// Queries collection data
        /// 
        /// <para>
        /// Queries data that satisfies the `filter` conditions,
        /// limits the number of returned records and orders them.
        /// The projection fields are limited to  `result` fields
        /// </para>
        /// </summary>
        Task<ResultOfQueryCollection> QueryCollection(ParamsOfQueryCollection @params);

        /// <summary>
        /// Returns an object that fulfills the conditions or waits for its appearance
        /// 
        /// <para>
        /// Triggers only once.
        /// If object that satisfies the `filter` conditions
        /// already exists - returns it immediately.
        /// If not - waits for insert/update of data withing the specified `timeout`,
        /// and returns it.
        /// The projection fields are limited to  `result` fields
        /// </para>
        /// </summary>
        Task<ResultOfWaitForCollection> WaitForCollection(ParamsOfWaitForCollection @params);

        /// <summary>
        /// Cancels a subscription specified by its handle.
        /// </summary>
        //Task Unsubscribe(ResultOfSubscribeCollection @params);

        /// <summary>
        /// Creates a subscription.
        /// 
        /// <para>
        /// Triggers for each insert/update of data
        /// that satisfies the `filter` conditions.
        /// The projection fields are limited to  `result` fields.
        /// </para>
        /// </summary>
        AsyncDataStream<string> SubscribeCollection(ParamsOfSubscribeCollection @params);
    }
}
