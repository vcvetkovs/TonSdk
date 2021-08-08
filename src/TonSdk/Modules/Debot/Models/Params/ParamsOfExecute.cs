namespace TonSdk.Modules.Debot.Models
{
	/// <summary>
	///     Parameters for executing debot action.
	/// </summary>
	public class ParamsOfExecute
    {
        /// <summary>
        ///     Debot handle which references an instance of debot engine.
        /// </summary>
        public uint DebotHandle { get; set; }

        /// <summary>
        ///     Debot Action that must be executed.
        /// </summary>
        public DebotAction Action { get; set; }
    }
}
