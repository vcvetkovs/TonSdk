namespace EverscaleSdk.Modules.Net.Models
{
    public struct ParamsOfIteratorNext
    {
        /// <summary>
        ///     Iterator handle.
        /// </summary>
        public uint Iterator { get; set; }

        /// <summary>
        ///     If value is missing or is less than 1 the library uses 1.
        /// </summary>
        public uint? Limit { get; set; }

        /// <summary>
        ///     Indicates that function must return the iterator state that can be used for resuming iteration.
        /// </summary>
        public bool? ReturnResumeState { get; set; }
    }
}
