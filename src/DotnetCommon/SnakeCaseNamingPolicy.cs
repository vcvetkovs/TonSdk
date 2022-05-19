using System.Text.Json;
using DotnetCommon.Extensions;

namespace DotnetCommon
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