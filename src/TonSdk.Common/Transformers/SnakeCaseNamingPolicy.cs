using System.Text.Json;
using TonSdk.Common.Helpers;

namespace TonSdk.Common.Transformers
{
    public class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        private static SnakeCaseNamingPolicy? _instance;
        public static SnakeCaseNamingPolicy Instance => _instance ??= new SnakeCaseNamingPolicy();

        public override string ConvertName(string name)
        {
            return StringHelper.ToSnakeCase(name);
        }
    }
}