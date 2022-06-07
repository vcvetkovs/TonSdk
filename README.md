# Everscale SDK .NET Bindings

**Community links:**

[![Chat on Telegram](https://img.shields.io/badge/chat-on%20telegram-9cf.svg)](https://t.me/everscale_sdk)
  
## Installation
### NuGet package
```
Install-Package TonSdk -Version 1.0.0-alpha
```
## API
[JSON schema](https://github.com/vcvetkovs/TonSdk/blob/main/tests/TonSdk.Tests/test-data/api.json)
## Usage examples
### Basic usage
```cs
var cfg = new ClientConfig
{
    Network = new NetworkConfig
    {
        ServerAddress = "net.ton.dev"
    }
};
using var client = new EverscaleClient(cfg);
var result = await client.Crypto.Sha256(new ParamsOfHash
{
    Data = "example of sha256"
});
var sha256 = result.Hash;
...
```
### Subscribing to async event stream
```cs
var cfg = new ClientConfig
{
    Network = new NetworkConfig
    {
        ServerAddress = "net.ton.dev"
    }
};
using var client = new EverscaleClient(cfg);
var @params = new ParamsOfSubscribeCollection
{
    Collection = "transactions",
    Filter = new
    {
        account_addr = new { eq = "-1:7777777777777777777777777777777777777777777777777777777777777777" },
    },
    Result = "now status balance_delta"
};
await foreach (var item in _sut.SubscribeCollection(@params))
{
    var transaction = JsonSerializer.Deserialize<Transaction>(item);
    if (transaction.BalanceDelta > 0)
    {
        Console.WriteLine("Found!");
        break;
    }
}
```

More of examples you can find [tests](https://github.com/vcvetkovs/TonSdk/tree/main/tests/EverscaleSdk.Tests)
