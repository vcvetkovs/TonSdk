using System.Text.Json;
using EverscaleSdk.Common.Helpers;

namespace EverscaleSdk.Common.Converters
{
    public class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        private static SnakeCaseNamingPolicy? _instance;
        public static SnakeCaseNamingPolicy Instance => _instance ??= new SnakeCaseNamingPolicy();

        public override string ConvertName(string name)
        {
            return name.ToSnakeCase();
        }
    }
}