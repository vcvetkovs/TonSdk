using System.Text.Json;
using TonSdk.Modules.Abi.Models;

namespace TonSdk.Modules.Processing.Models
{
    public struct DecodedOutput
    {
        /// <summary>
        /// Decoded bodies of the out messages.
        /// 
        /// If the message can't be decoded then `None` will be stored in
        /// the appropriate position.
        /// </summary>
        public DecodedMessageBody?[] OutMessages { get; set; }

        /// <summary>
        /// Decoded body of the function output message.
        /// </summary>
        public JsonElement? Output { get; set; }
    }
}
