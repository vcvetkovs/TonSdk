using System.Text.Json.Serialization;

namespace EverscaleSdk.Modules.Client.Models
{
    public struct ResultOfBuildInfo
    {
        /// <summary>
        ///     Build number assigned to this build by the CI.
        /// </summary>
        public uint BuildNumber { get; set; }

        /// <summary>
        ///     Fingerprint of the most important dependencies.
        /// </summary>
        public BuildInfoDependency[] Dependencies { get; set; }
    }

    public struct BuildInfoDependency
    {
        /// <summary>
        ///     Usually it is a crate name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Git commit hash of the related repository.
        /// </summary>
        public string GitCommit { get; set; }
    }

    public struct CommitInfo
    {
        [JsonPropertyName("git-commit")]
        public string GitCommit { get; set; }
    }
}
