using System.Text.Json;
using TonSdk.Modules.Abi.Enums;

namespace TonSdk.Modules.Abi.Models
{
    public struct DecodedMessageBody
    {
        /// <summary>
        ///     Type of the message body content.
        /// </summary>
        public MessageBodyType BodyType { get; set; }

        /// <summary>
        ///     Function or event name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Parameters or result value.
        /// </summary>
        public JsonElement? Value { get; set; }

        /// <summary>
        ///     Function header.
        /// </summary>
        public FunctionHeader? Header { get; set; }
    }
}
