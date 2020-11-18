using System.Text.Json;

namespace TonSdk.Modules.Tvm.Models
{
    public struct ResultOfRunGet
    {
        /// <summary>
        /// Values returned by getmethod on stack.
        /// </summary>
        public JsonElement Output { get; set; }
    }
}
