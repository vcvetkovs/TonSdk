using System.Text.Json;
using EverscaleSdk.Modules.Abi.Models;

namespace EverscaleSdk.Modules.Processing.Models
{
    public struct DecodedOutput
    {
        /// <summary>
        ///     Decoded bodies of the out messages.
        /// </summary>
        /// <remarks>
        ///     If the message can't be decoded then `None` will be stored in
        ///     the appropriate position.
        /// </remarks>
        public DecodedMessageBody?[] OutMessages { get; set; }

        /// <summary>
        ///     Decoded body of the function output message.
        /// </summary>
        public JsonElement? Output { get; set; }
    }
}
