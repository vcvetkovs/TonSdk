namespace EverscaleSdk.Modules.Debot.Models
{
	/// <summary>
	///     Returning values from Debot Browser callbacks.
	/// </summary>
	public abstract class ResultOfAppDebotBrowser
    {
        /// <summary>
        ///     Result of user input.
        /// </summary>
        public class Input : ResultOfAppDebotBrowser
        {
            /// <summary>
            ///     String entered by user.
            /// </summary>
            public string Value { get; set; }
        }

        /// <summary>
        ///     Result of getting signing box.
        /// </summary>
        public class GetSigningBox : ResultOfAppDebotBrowser
        {
            /// <summary>
            ///     Signing box for signing data requested by debot engine. <para/>
            ///     
            ///     Signing box is owned and disposed by debot engine.
            /// </summary>
            public uint SigningBox { get; set; }
        }

        /// <summary>
        ///     Result of debot invoking.
        /// </summary>
        public class InvokeDebot : ResultOfAppDebotBrowser
        {
        }

        /// <summary>
        ///     Result of <c>approve</c> callback.
        /// </summary>
        public class Approve : ResultOfAppDebotBrowser
        {
            /// <summary>
            ///     Indicates whether the DeBot is allowed to perform the specified operation.
            /// </summary>
            public bool Approved { get; set; }
        }
    }
}
