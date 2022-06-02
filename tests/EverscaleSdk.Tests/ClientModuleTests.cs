using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using EverscaleSdk.Modules.Client;
using EverscaleSdk.Modules.Client.Models;
using Xunit;

namespace EverscaleSdk.Tests
{
    public class ClientModuleTests
    {
        private readonly IClientModule _sut;
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public ClientModuleTests()
        {
            var client = new EverscaleClient();
            _jsonSerializerOptions = client.JsonSerializerOptions;
            _sut = client.Client;
        }
    }
}
