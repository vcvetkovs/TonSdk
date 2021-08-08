using System.Text.Json;

namespace TonSdk.Modules.Net.Models
{
    public struct ResultOfIteratorNext
    {
        /// <summary>
        ///     Note that <c>iterator_next</c> can return an empty items and <see cref="HasMore"/> equals to <c>true</c>.
        ///     In this case the application have to continue iteration.
        ///     Such situation can take place when there is no data yet but
        ///     the requested <c>end_time</c> is not reached.
        /// </summary>
        public JsonElement[] Items { get; set; }

        /// <summary>
        ///     Indicates that there are more available items in iterated range.
        /// </summary>
        public bool HasMore { get; set; }

        /// <summary>
        ///     This field is returned only if the <see cref="ParamsOfIteratorNext.ReturnResumeState"/>
        ///     parameter is specified.
        /// </summary>
        /// <remarks>
        ///     Note that <see cref="ResumeState"/> corresponds to the iteration position
        ///     after the returned items.
        /// </remarks>
        public JsonElement ResumeState { get; set; }
    }
}
