using System.Text.Json.Serialization;

namespace TonSdk.Modules.Client.Models
{
    public struct ResultOfBuildInfo
    {
        public BuildInfo BuildInfo { get; set; }
    }

    public struct BuildInfo
    {
        [JsonPropertyName("buildNumber")]
        public uint BuildNumber { get; set; }

        [JsonPropertyName("ton-labs-types")]
        public CommitInfo TonLabsTypes { get; set; }

        [JsonPropertyName("ton-labs-block")]
        public CommitInfo TonLabsBlock { get; set; }

        [JsonPropertyName("ton-labs-block-json")]
        public CommitInfo TonLabsBlockJson { get; set; }

        [JsonPropertyName("ton-labs-vm")]
        public CommitInfo TonLabsVm { get; set; }

        [JsonPropertyName("ton-labs-abi")]
        public CommitInfo TonLabsAbi { get; set; }

        [JsonPropertyName("ton-labs-executor")]
        public CommitInfo TonLabsExecutor { get; set; }
    }

    public struct CommitInfo
    {
        [JsonPropertyName("git-commit")]
        public string GitCommit { get; set; }
    }
}
