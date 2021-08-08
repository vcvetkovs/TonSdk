using System;

namespace TonSdk.Configs
{
    public struct NetworkConfig
    {
        /// <summary>
        ///     DApp Server public address.
        /// </summary>
        /// <remarks>
        ///     For instance, for <c>net.ton.dev/graphql</c> GraphQL endpoint the server address will be net.ton.dev
        /// </remarks>
        public string? ServerAddress { get; set; }

        /// <summary>
        ///     List of DApp Server addresses.
        /// </summary>
        /// <remarks>
        ///     Any correct URL format can be specified, including IP addresses.
        ///     This parameter is prevailing over <see cref="ServerAddress"/>.
        /// </remarks>
        public string[] Endpoints { get; set; }

        /// <summary>
        ///     Deprecated.<para/>
        ///     
        ///     You must use <see cref="MaxReconnectTimeout"/> that allows to specify maximum network resolving timeout.
        /// </summary>
        [Obsolete]
        public sbyte? NetworkRetriesCount { get; set; }

        /// <summary>
        ///     Maximum time for sequential reconnections.
        /// </summary>
        /// <remarks>
        ///     Must be specified in milliseconds. Default value is 120000 (2 min).
        /// </remarks>
        public uint? MaxReconnectTimeout { get; set; }

        /// <summary>
        ///     Deprecated.
        /// </summary>
        public uint? ReconnectTimeout { get; set; }

        /// <summary>
        ///     The number of automatic message processing retries that SDK performs in case of <see cref="Modules.Processing.Enums.ProcessingErrorCode.MessageExpired"/> error
        /// </summary>
        /// <remarks>
        ///     Only for those messages which local emulation was successful or failed with replay protection error.
        ///  <para/>
        ///     The default value is 5.
        ///  <para/>
        /// </remarks>
        public sbyte? MessageRetriesCount { get; set; }

        /// <summary>
        ///     Timeout that is used to process message delivery for the contracts which ABI does not include "expire" header.
        /// </summary>
        /// <remarks>
        ///     Must be specified in milliseconds. Default is 40000 (40 sec).
        ///  <para/>
        ///     If the message is not delivered within the specified timeout the appropriate error occurs.
        ///  <para/>
        /// </remarks>
        public uint? MessageProcessingTimeout { get; set; }

        /// <summary>
        ///     Maximum timeout that is used for query response.
        /// </summary>
        /// <remarks>
        ///     Must be specified in milliseconds. Default is 40000 (40 sec).
        /// </remarks>
        public uint? WaitForTimeout { get; set; }

        /// <summary>
        ///     Maximum time difference between server and client.
        /// </summary>
        /// <remarks>
        ///     If client's device time is out of sync and difference is more than the threshold then error will occur.
        ///  <para/>
        ///     Also an error will occur if the specified threshold is more than <see cref="MessageProcessingTimeout" />/2.
        ///  <para/>
        ///     Must be specified in milliseconds. Default is 15000 (15 sec).
        ///  <para/>
        /// </remarks>
        public uint? OutOfSyncThreshold { get; set; }

        /// <summary>
        ///     Maximum number of randomly chosen endpoints the library uses to broadcast a message.
        /// </summary>
        /// <remarks>
        ///     Default is 2.
        /// </remarks>
        public byte? SendingEndpointCount { get; set; }

        /// <summary>
        ///     Frequency of sync latency detection.
        /// </summary>
        /// <remarks>
        ///     Library periodically checks the current endpoint for blockchain data syncronization latency.
        ///  <para/>
        ///     If the latency (time-lag) is less then <see cref="MaxLatency"/> then library selects another endpoint.
        ///  <para/>
        ///     Must be specified in milliseconds. Default is 60000 (1 min).
        ///  <para/>
        /// </remarks>
        public uint? LatencyDetectionInterval { get; set; }

        /// <summary>
        ///     Maximum value for the endpoint's blockchain data syncronization latency (time-lag).
        /// </summary>
        /// <remarks>
        ///     Library periodically checks the current endpoint for blockchain data syncronization latency.
        ///  <para/>
        ///     If the latency (time-lag) is less then <see cref="MaxLatency"/> then library selects another endpoint.
        ///  <para/>
        ///     Must be specified in milliseconds. Default is 60000 (1 min).
        ///  <para/>
        /// </remarks>
        public uint? MaxLatency { get; set; }

        /// <summary>
        ///     Default timeout for http requests.
        /// </summary>
        /// <remarks>
        ///     Is is used when no timeout specified for the request to limit the answer waiting time.
        ///  <para/>
        ///     If no answer received during the timeout requests ends with error.
        ///  <para/>
        ///     Must be specified in milliseconds. Default is 60000 (1 min).
        ///  <para/>
        /// </remarks>
        public uint? QueryTimeout { get; set; }

        /// <summary>
        ///     Access key to GraphQL API.
        /// </summary>
        /// <remarks>
        ///     At the moment is not used in production
        /// </remarks>
        public string? AccessKey { get; set; }
    }
}
