namespace EverscaleSdk.Modules.Debot.Models
{
	/// <summary>
	///		Parameters to start DeBot. DeBot must be already initialized with init().
	/// </summary>
	public struct ParamsOfStart
	{
		/// <summary>
		///		Debot handle which references an instance of debot engine.
		/// </summary>
		public uint DebotHandle { get; set; }
	}
}
