namespace TonSdk.Modules.Debot.Models
{

	/// <summary>
	///     Describes the operation that the DeBot wants to perform.
	/// </summary>
	public abstract class DebotActivity
    {
        /// <summary>
        ///     DeBot wants to create new transaction in blockchain.
        /// </summary>
        public class Transaction : DebotActivity
        {
            /// <summary>
            ///     External inbound message BOC.
            /// </summary>
            public string Msg { get; set; }

            /// <summary>
            ///     Target smart contract address.
            /// </summary>
            public string Dst { get; set; }

            /// <summary>
            ///     List of spendings as a result of transaction.
            /// </summary>
            public Spending[] Out { get; set; }

            /// <summary>
            ///     Transaction total fee.
            /// </summary>
            public ulong Fee { get; set; }

            /// <summary>
            ///     Indicates if target smart contract updates its code.
            /// </summary>
            public bool Setcode { get; set; }

            /// <summary>
            ///     Public key from keypair that was used to sign external message.
            /// </summary>
            public string Signkey { get; set; }

            /// <summary>
            ///     Signing box handle used to sign external message.
            /// </summary>
            public uint SigningBoxHandle { get; set; }
        }
    }
}
