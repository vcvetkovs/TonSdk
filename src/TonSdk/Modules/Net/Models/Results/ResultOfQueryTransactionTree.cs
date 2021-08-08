namespace TonSdk.Modules.Net.Models
{
    public struct ResultOfQueryTransactionTree
    {
        public MessageNode[] Messages { get; set; }

        public TransactionNode[] Transactions { get; set; }
    }
}
