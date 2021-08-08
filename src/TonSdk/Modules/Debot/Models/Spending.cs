namespace TonSdk.Modules.Debot.Models
{
    /// <summary>
    ///     Describes how much funds will be debited from the target  contract balance
    ///     as a result of the transaction.
    /// </summary>
    public struct Spending
    {
        /// <summary>
        ///     Amount of nanotokens that will be sent to <see cref="Dst"/> address.
        /// </summary>
        public ulong Amount { get; set; }

        /// <summary>
        ///     Destination address of recipient of funds.
        /// </summary>
        public string Dst { get; set; }
    }
}
