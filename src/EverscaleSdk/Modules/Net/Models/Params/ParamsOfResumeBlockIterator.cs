namespace EverscaleSdk.Modules.Net.Models
{
    public struct ParamsOfResumeBlockIterator
    {
        /// <summary>
        ///     Same as value returned from <see cref="INetModule.IteratorNext(ParamsOfIteratorNext)"/>.
        /// </summary>
        public dynamic ResumeState { get; set; }
    }
}
