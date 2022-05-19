using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace DotnetCommon.Extensions
{
    public static class JsonElementExtensions
    {
        private static string[] PlularWordEndings = new[] { "es", "s" };

        public static IEnumerable<IDictionary<string, string>> GetArray(
            this JsonElement jsonElement,
            params string[] fields)
        {
            var props = jsonElement
                .EnumerateObject()
                .Where(x => fields.Length == 0 || fields.Contains(x.Name))
                .ToDictionary(
                    x =>
                    {
                        var name = x.Name;
                        foreach (var wordEnding in PlularWordEndings)
                        {
                            if (name.EndsWith(wordEnding))
                            {
                                name = name.Substring(0, name.Length - wordEnding.Length);
                                break;
                            }
                        }
                        return name;
                    },
                    x => x.Value.EnumerateArray().ToArray()
                );

            return props.First().Value.Select((x, i) =>
            {
                var item = new Dictionary<string, string>();
                foreach (var prop in props)
                {
                    item.Add(prop.Key, prop.Value.ElementAt(i).GetString());
                }

                return item;
            });
        }

        public static string GetString(
            this JsonElement jsonElement,
            string propertyName) => jsonElement.GetProperty(propertyName).GetString();

        public static string GetHexString(
            this JsonElement jsonElement,
            string propertyName) => jsonElement.GetString(propertyName).FromHex();
    }
}
