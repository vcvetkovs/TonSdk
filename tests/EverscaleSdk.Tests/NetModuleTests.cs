using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EverscaleSdk.Configs;
using EverscaleSdk.Modules.Net;
using EverscaleSdk.Modules.Net.Models;
using Xunit;

namespace EverscaleSdk.Tests
{
    public class NetModuleTests
    {
        private readonly INetModule _sut;

        public NetModuleTests()
        {
            _sut = new EverscaleClient(new ClientConfig
            {
                Network = new NetworkConfig
                {
                    ServerAddress = "net.ton.dev"
                }
            })
            .Net;
        }

        [Fact]
        public async Task QueryCollection_BlockSignaturesQuery_QueryResultNotNull()
        {
            // Arrange
            var @params = new ParamsOfQueryCollection
            {
                Collection = "blocks_signatures",
                Filter = new { },
                Result = "id",
                Limit = 1,
                Order = null
            };

            // Act
            var result = await _sut
                .QueryCollection(@params);

            // Assert
            Assert.NotNull(result.Result);
        }

        [Fact]
        public async Task QueryCollection_AccountsQuery_ResultCountMoreThan0()
        {
            // Arrange
            var @params = new ParamsOfQueryCollection
            {
                Collection = "accounts",
                Filter = new { },
                Result = "id balance",
                Limit = null,
                Order = null
            };

            // Act
            var result = await _sut
                .QueryCollection(@params);

            // Assert
            Assert.True(result.Result.Length > 0);
        }

        [Fact]
        public async Task QueryCollection_MessageQueryInRange_FirstResultIsInRange()
        {
            // Arrange
            var @params = new ParamsOfQueryCollection
            {
                Collection = "messages",
                Filter = new
                {
                    created_at = new
                    {
                        gt = 1562342740
                    }
                },
                Result = "body created_at",
                Limit = null,
                Order = null
            };

            // Act
            var result = await _sut
                .QueryCollection(@params);

            // Assert
            Assert.True(result.Result[0].GetProperty("created_at").GetUInt64() > 1562342740);
        }

        [Fact]
        public async Task WaitForCollection_WaitForTransaction_ResultTransactionGreaterThanNow()
        {
            // Arrange
            var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var @params = new ParamsOfWaitForCollection
            {
                Collection = "transactions",
                Filter = new
                {
                    now = new
                    {
                        gt = now
                    }
                },
                Result = "id now",
                Timeout = null
            };

            // Act
            var result = await _sut
                .WaitForCollection(@params);

            // Assert
            var nowLong = (ulong)now;
            Assert.True(result.Result.GetProperty("now").GetUInt64() > nowLong);
        }

        [Fact]
        public async Task SubscribeCollection_ListeningForFirst10Events_EventsShouldBe10()
        {
            // Arrange
            var @params = new ParamsOfSubscribeCollection
            {
                Collection = "transactions",
                Filter = new
                {
                    status = new { eq = 3 }
                },
                Result = "id account_addr"
            };

            var results = new List<string>();
            // Act
            await foreach (var item in _sut.SubscribeCollection(@params))
            {
                results.Add(item);
                if (results.Count == 10)
                    break;
            }

            // Assert
            Assert.Equal(10, results.Count);
        }
    }
}
