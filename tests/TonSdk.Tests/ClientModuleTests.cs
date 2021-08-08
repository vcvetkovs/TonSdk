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
    }
}
