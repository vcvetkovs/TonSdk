using TonSdk.Modules.Abi.Enums;

namespace TonSdk.Modules.Abi.Models
{
    public struct ParamsOfEncodeAccount
    {
        /// <summary>
        /// Source of the account state init.
        /// </summary>
        public StateInitSource StateInit { get; set; }

        /// <summary>
        /// Initial balance.
        /// </summary>
        public ulong? Balance { get; set; }

        /// <summary>
        /// Initial value for the `last_trans_lt`.
        /// </summary>
        public ulong? LastTransLt { get; set; }

        /// <summary>
        /// Initial value for the `last_paid`.
        /// </summary>
        public uint? LastPaid { get; set; }
    }
}
