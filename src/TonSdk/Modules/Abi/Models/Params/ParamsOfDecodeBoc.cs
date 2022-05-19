namespace TonSdk.Modules.Abi.Models
{
	public struct ParamsOfDecodeBoc
    {
        /// <summary>
        ///     Parameters to decode from BOC.
        /// </summary>
        public AbiParameter[] Params { get; set; }

        /// <summary>
        ///     Data BOC or BOC handle.
        /// </summary>
        public string Boc { get; set; }

        public bool AllowPartial { get; set; }
    }
}
