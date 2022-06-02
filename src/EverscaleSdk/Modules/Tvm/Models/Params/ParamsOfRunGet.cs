namespace EverscaleSdk.Modules.Tvm.Models
{
    public struct ParamsOfRunGet
    {
        /// <summary>
        ///     Account BOC in <c>base64<c>
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        ///     Function name.
        /// </summary>
        public string FunctionName { get; set; }

        /// <summary>
        ///     Input parameters.
        /// </summary>
        public object? Input { get; set; }

        /// <summary>
        ///     Execution options.
        /// </summary>
        public ExecutionOptions ExecutionOptions { get; set; }

        /// <remarks>
        /// Default is <c>false</c>. Input parameters may use any of lists representations
        /// If you receive this error on Web: "Runtime error. Unreachable code should not be executed...",
        /// set this flag to true.
        /// This may happen, for example, when elector contract contains too many participants
        /// </remarks>
        public bool? TupleListAsArray { get; set; }
    }
}
