using System.Threading.Tasks;
using TonSdk.Modules.Utils.Enums;
using TonSdk.Modules.Utils.Models;

namespace TonSdk.Modules.Utils
{
    public class UtilsModule : IUtilsModule
    {
        private readonly ITonClient _client;

        public UtilsModule(ITonClient client)
        {
            _client = client;
        }

        public Task<string> ConvertAddressToAccountId(string address)
        {
            var @params = new ParamsOfConvertAddress
            {
                Address = address,
                OutputFormat = new Models.AddressStringFormat
                {
                    Type = AddressStringFormatType.AccountId
                }
            };
            return ConvertAddress(@params);
        }

        public Task<string> ConvertAddressToHex(string address)
        {
            var @params = new ParamsOfConvertAddress
            {
                Address = address,
                OutputFormat = new Models.AddressStringFormat
                {
                    Type = AddressStringFormatType.Hex
                }
            };
            return ConvertAddress(@params);
        }

        public Task<string> ConvertAddressToBase64(
            string address,
            bool url = false,
            bool test = false,
            bool bounce = false)
        {
            var @params = new ParamsOfConvertAddress
            {
                Address = address,
                OutputFormat = new Models.AddressStringFormat
                {
                    Type = AddressStringFormatType.Base64,
                    Url = url,
                    Test= test,
                    Bounce = bounce
                }
            };
            return ConvertAddress(@params);
        }

        private async Task<string> ConvertAddress(ParamsOfConvertAddress @params)
        {
            var resultOfConvertAddress = await _client
                .CallFunction<ResultOfConvertAddress>(Consts.Commands.ConvertAddress, @params);
            return resultOfConvertAddress.Address;
        }
    }
}
