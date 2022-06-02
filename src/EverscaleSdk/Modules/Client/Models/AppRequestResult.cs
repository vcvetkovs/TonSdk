namespace EverscaleSdk.Modules.Client.Models
{
	public abstract class AppRequestResult
    {
        /// <summary>
        ///     Error occured during request processing.
        /// </summary>
        public class Error : AppRequestResult
        {
            /// <summary>
            ///     Error description.
            /// </summary>
            public string Text { get; set; }
        }

        /// <summary>
        ///     Request processed successfully.
        /// </summary>
        public class Ok : AppRequestResult
        {
            /// <summary>
            ///     Request processing result.
            /// </summary>
            public object Result { get; set; }
        }
    }
}
