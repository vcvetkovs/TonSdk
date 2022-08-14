namespace EverscaleSdk.Modules.Abi.Models
{
	public struct ParamsOfCalcFunctionId
    {
        /// <summary>
        ///     Contract ABI.
        /// </summary>
        public Abi Abi { get; set; }

        /// <summary>
        ///     Contract function name.
        /// </summary>
        public string FunctionName { get; set; }

        /// <summary>
        ///     If set to <see langword="true"/> output function ID will be
        ///     returned which is used in contract response.
        /// </summary>
        /// <remarks>
        ///     Default is <see langword="false"/>
        /// </remarks>
        public bool? Output { get; set; }
    }
}

