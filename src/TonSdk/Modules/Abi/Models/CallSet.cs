using System.Text.Json;

namespace TonSdk.Modules.Abi.Models
{
    /// <summary>
    /// Function call parameters.
    /// <para>
    /// Must be specified in non deploy message.
    /// In case of deploy message contains parameters of constructor.
    /// </para>
    /// </summary>
    public struct CallSet
    {
        /// <summary>
        /// Function name that is being called.
        /// </summary>
        public string FunctionName { get; set; }

        /// <summary>
        /// Function header.
        /// If an application omits some header parameters required by the
        /// contract's ABI, the library will set the default values for them.
        /// </summary>
        public FunctionHeader? Header { get; set; }

        /// <summary>
        /// Function input parameters according to ABI.
        /// </summary>
        public JsonElement? Input { get; set; }
    }
}
