using System.Globalization;

namespace TonSdk.Common.Helpers
{
    public static class HexHelper
    {
        public static string ToBase64(string hexString)
        {
            return System.Convert.ToBase64String(ToBytes(hexString));
        }

        public static byte[] ToBytes(string hexString)
        {
            byte[] byteArray = new byte[hexString.Length / 2];

            for (int index = 0; index < byteArray.Length; index++)
            {
                string byteValue = hexString.Substring(index * 2, 2);
                byteArray[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }

            return byteArray;
        }
    }
}
