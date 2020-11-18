using System.Text.Json;

namespace TonSdk.Modules.Tvm.Models
{
    public struct ParamsOfRunGet
    {
        /// <summary>
        /// Account BOC in `base64`
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Function name.
        /// </summary>
        public string FunctionName { get; set; }

        /// <summary>
        /// Input parameters.
        /// </summary>
        public JsonElement? Input { get; set; }

        public ExecutionOptions? ExecutionOptions { get; set; }
    }
}
