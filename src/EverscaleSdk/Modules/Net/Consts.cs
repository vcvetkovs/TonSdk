namespace EverscaleSdk.Modules.Net
{
    public class Consts
    {
        public class Commands
        {
            public const string Query = "net.query";
            public const string BatchQuery = "net.batch_query";
            public const string QueryCollection = "net.query_collection";
            public const string AggregateCollection = "net.aggregate_collection";
            public const string WaitForCollection = "net.wait_for_collection";
            public const string Unsubscribe = "net.unsubscribe";
            public const string SubscribeCollection = "net.subscribe_collection";
            public const string Subscribe = "net.subscribe";
            public const string Suspend = "net.suspend";
            public const string Resume = "net.resume";
            public const string FindLastShardBlock = "net.find_last_shard_block";
            public const string FetchEndpoints = "net.fetch_endpoints";
            public const string SetEndpoints = "net.set_endpoints";
            public const string GetEndpoints = "net.get_endpoints";
            public const string QueryCounterparties = "net.query_counterparties";
            public const string QueryTransactionTree = "net.query_transaction_tree";
            public const string CreateBlockIterator = "net.create_block_iterator";
            public const string ResumeBlockIterator = "net.resume_block_iterator";
            public const string CreateTransactionIterator = "net.create_transaction_iterator";
            public const string ResumeTransactionIterator = "net.resume_transaction_iterator";
            public const string IteratorNext = "net.iterator_next";
            public const string RemoveIterator = "net.remove_iterator";
        }
    }
}
