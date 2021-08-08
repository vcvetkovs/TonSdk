namespace TonSdk.Modules.Tvm.Models
{
    public abstract class AccountForExecutor
    {
        /// <summary>
        ///     Non-existing account to run a creation internal message.
        /// </summary>
        /// <remarks>
        ///     Should be used with <c>skip_transaction_check = true</c> if the message has no deploy data
        ///     since transaction on the unitialized account are always aborted.
        /// </remarks>
        public class None : AccountForExecutor
        {
        }

        /// <summary>
        ///     Emulate unitialized account to run deploy message.
        /// </summary>
        public class Uninit : AccountForExecutor
        {
        }

        /// <summary>
        ///     Account state to run message.
        /// </summary>
        public class Account : AccountForExecutor
        {
            /// <summary>
            ///     Encoded as base64.
            /// </summary>
            public string Boc { get; set; }

            /// <summary>
            ///     Can be used to calculatetransaction fees without balance check.
            /// </summary>
            public bool? UnlimitedBalance { get; set; }
        }
    }
}
