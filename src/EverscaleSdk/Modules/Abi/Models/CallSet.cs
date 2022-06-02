namespace EverscaleSdk.Modules.Abi.Models
{
    /// <summary>
    ///     Function call parameters.
    /// </summary>
    /// <remarks>
    ///     Must be specified in non deploy message.
    ///     In case of deploy message contains parameters of constructor.
    /// </remarks>
    public struct CallSet
    {
        /// <summary>
        ///     Function name that is being called.
        ///     Or function id encoded as string in hex (starting with 0x).
        /// </summary>
        public string FunctionName { get; set; }

        /// <summary>
        ///     If an application omits some header parameters required by the
        ///     contract's ABI, the library will set the default values for them.
        /// </summary>
        public FunctionHeader? Header { get; set; }

        /// <summary>
        ///     Function input parameters according to ABI.
        /// </summary>
        public object? Input { get; set; }
    }
}
