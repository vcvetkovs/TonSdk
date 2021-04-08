namespace TonSdk.Modules.Boc
{
    public class Consts
    {
        public class Commands
        {
            public const string ParseMessage = "boc.parse_message";
            public const string ParseAccount = "boc.parse_account";
            public const string ParseTransaction = "boc.parse_transaction";
            public const string ParseBlock = "boc.parse_block";
            public const string ParseShardState = "boc.parse_shardstate";
            public const string GetBlockchainConfig = "boc.get_blockchain_config";
            public const string GetBocHash = "boc.get_boc_hash";
            public const string GetCodeFromTvc = "boc.get_code_from_tvc";
            public const string CacheGet = "boc.cache_get";
            public const string CacheSet = "boc.cache_set";
            public const string CacheUnpin = "boc.cache_unpin";
            public const string EncodeBoc = "boc.encode_boc";
        }
    }
}
