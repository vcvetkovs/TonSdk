namespace TonSdk.Modules.Tvm.Enums
{
    public enum AccountForExecutor
    {
        /// <summary>
        /// Non-existing account to run a creation internal message.
        /// Should be used with `skip_transaction_check = true` if the message has no deploy data
        /// since transaction on the unitialized account are always aborted
        /// </summary>
        None,

        /// <summary>
        /// Emulate unitialized account to run deploy message.
        /// </summary>
        Uninit,

        /// <summary>
        /// Account state to run message.
        /// </summary>
        Account
    }
}
