using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using TonSdk.Modules.Client;
using TonSdk.Modules.Client.Models;
using Xunit;

namespace TonSdk.Tests
{
    public class ClientModuleTests
    {
        private readonly IClientModule _sut;
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public ClientModuleTests()
        {
            var client = new TonClient();
            _jsonSerializerOptions = client.JsonSerializerOptions;
            _sut = client.Client;
        }

        [Fact]
        public async Task GetApiReference_IsValid_True()
        {
            // Act
            var apiJson = File.ReadAllText("test-data/api.json");
            var expected = JsonSerializer.Deserialize<Api>(apiJson, _jsonSerializerOptions);
            var result = await _sut.GetApiReference();

            var expectedJson = JsonSerializer.Serialize(expected, _jsonSerializerOptions).Replace(" ", "");
            var resultJson = JsonSerializer.Serialize(result.Api, _jsonSerializerOptions).Replace(" ", "");
            Assert.Equal(expectedJson, resultJson);
        }

        [Fact]
        public async Task GetVersion_IsValid_True()
        {
            // Act
            var result = await _sut.GetVersion();

            // Assert
            Assert.Equal("1.0.0", result.Version);
        }

        [Fact]
        public async Task GetBuildInfo_IsValid_True()
        {
            // Act
            var result = await _sut.GetBuildInfo();

            // Assert
            Assert.Equal<uint>(839, result.BuildInfo.BuildNumber);
            Assert.Equal("04f832045593b43a46f71f6a2dd2c8fad8295a23", result.BuildInfo.TonLabsAbi.GitCommit);
            Assert.Equal("9b01940e207d9ba214bb69c8e9eb45e64f5dce2b", result.BuildInfo.TonLabsBlock.GitCommit);
            Assert.Equal("f5cd84fc93afd44ad3e57bdc11392031967d08f3", result.BuildInfo.TonLabsBlockJson.GitCommit);
            Assert.Equal("dd6db9023e69cf77fe500fa9cdd10eabdcaed23b", result.BuildInfo.TonLabsExecutor.GitCommit);
            Assert.Equal("87a1d1ce336cb5d310fd631d99e293c6599021f1", result.BuildInfo.TonLabsVm.GitCommit);
        }
    }
}
