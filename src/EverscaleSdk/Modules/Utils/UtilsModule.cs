using System.Threading.Tasks;
using EverscaleSdk.Modules.Utils.Models;

namespace EverscaleSdk.Modules.Utils
{
    public class UtilsModule : IUtilsModule
    {
        private readonly IEverscaleClient _client;

        public UtilsModule(IEverscaleClient client)
        {
            _client = client;
        }

        public Task<string> ConvertAddressToAccountId(string address)
        {
            var @params = new ParamsOfConvertAddress
            {
                Address = address,
                OutputFormat = new AddressStringFormat.AccountId()
            };
            return ConvertAddress(@params);
        }

        public Task<string> ConvertAddressToHex(string address)
        {
            var @params = new ParamsOfConvertAddress
            {
                Address = address,
                OutputFormat = new AddressStringFormat.Hex()
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
                OutputFormat = new AddressStringFormat.Base64
                {
                    Url = url,
                    Test = test,
                    Bounce = bounce
                }
            };
            return ConvertAddress(@params);
        }

        public async Task<string> ConvertAddress(ParamsOfConvertAddress @params)
        {
            var resultOfConvertAddress = await _client
                .CallFunction<ResultOfConvertAddress>(Consts.Commands.ConvertAddress, @params);
            return resultOfConvertAddress.Address;
        }

        public Task<ResultOfGetAddressType> GetAddressType(ParamsOfGetAddressType @params)
        {
            return _client
                .CallFunction<ResultOfGetAddressType>(Consts.Commands.GetAddressType, @params);
        }

        public Task<ResultOfCalcStorageFee> CalcStorageFee(ParamsOfCalcStorageFee @params)
        {
            return _client
                .CallFunction<ResultOfCalcStorageFee>(Consts.Commands.CalcStorageFee, @params);
        }

        public Task<ResultOfCompressZstd> CompressZstd(ParamsOfCompressZstd @params)
        {
            return _client
                .CallFunction<ResultOfCompressZstd>(Consts.Commands.CompressZstd, @params);
        }

        public Task<ResultOfDecompressZstd> DecompressZstd(ParamsOfDecompressZstd @params)
        {
            return _client
                .CallFunction<ResultOfDecompressZstd>(Consts.Commands.DecompressZstd, @params);
        }
    }
}
