using System.Text.Json.Serialization;
using TonSdk.Common.Converters;

namespace TonSdk.Modules.Debot.Models
{
    /// <summary>
    ///     Debot Browser callbacks.
    /// </summary>
    /// <remarks>
    ///     Called by debot engine to communicate with debot browser.
    /// </remarks>
    public abstract class ParamsOfAppDebotBrowser
    {
        /// <summary>
        ///     Print message to user. 
        /// </summary>
        public class Log : ParamsOfAppDebotBrowser
        {
            /// <summary>
            ///     A string that must be printed to user.
            /// </summary>
            public string Msg { get; set; }
        }

        /// <summary>
        ///     Switch debot to another context (menu).
        /// </summary>
        public class Switch : ParamsOfAppDebotBrowser
        {
            /// <summary>
            ///     Debot context ID to which debot is switched.
            /// </summary>
            public byte ContextId { get; set; }
        }

        /// <summary>
        ///     Notify browser that all context actions are shown.
        /// </summary>
        public class SwitchCompleted : ParamsOfAppDebotBrowser
        {
        }

        /// <summary>
        ///     Show action to the user.
        ///     Called after `switch` for each action in context.
        /// </summary>
        public class ShowAction : ParamsOfAppDebotBrowser
        {
            /// <summary>
            ///     Debot action that must be shown to user as menu item.
            ///     At least `description` property must be shown from [DebotAction] structure.
            /// </summary>
            public DebotAction Action { get; set; }
        }

        /// <summary>
        ///     Request user input. 
        /// </summary>
        public class Input : ParamsOfAppDebotBrowser
        {
            /// <summary>
            ///     A prompt string that must be printed to user before input request.
            /// </summary>
            public string Prompt { get; set; }
        }

        /// <summary>
        ///     Get signing box to sign data. Signing box returned is owned and disposed by debot engine
        /// </summary>
        public class GetSigningBox : ParamsOfAppDebotBrowser
        {
        }

        /// <summary>
        ///     Execute action of another debot.
        /// </summary>
        public class InvokeDebot : ParamsOfAppDebotBrowser
        {
            /// <summary>
            ///     Address of debot in blockchain.
            /// </summary>
            public string DebotAddr { get; set; }

            /// <summary>
            ///     Debot action to execute.
            /// </summary>
            public DebotAction Action { get; set; }
        }

        /// <summary>
        ///     Used by Debot to call DInterface implemented by Debot Browser.
        /// </summary>
        public class Send : ParamsOfAppDebotBrowser
        {
            /// <summary>
            ///     Message body contains interface function and parameters.
            /// </summary>
            public string Message { get; set; }
        }

        /// <summary>
        ///     Requests permission from DeBot Browser to execute DeBot operation.
        /// </summary>
        public class Approve : ParamsOfAppDebotBrowser
        {
            /// <summary>
            ///     DeBot activity details.
            /// </summary>
            [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
            public DebotActivity Activity { get; set; }
        }
    }
}
