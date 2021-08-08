using System;
using System.Text.Json;
using System.Threading.Tasks;
using TonSdk.Modules.Crypto.Models;

namespace TonSdk.Modules.Crypto
{
    public class CryptoModule : ICryptoModule
    {
        private readonly ITonClient _client;

        public CryptoModule(ITonClient client)
        {
            _client = client;
        }

        public Task<ResultOfFactorize> Factorize(ParamsOfFactorize @params)
        {
            return _client.CallFunction<ResultOfFactorize>(Consts.Commands.Factorize, @params);
        }

        public Task<ResultOfModularPower> ModularPower(ParamsOfModularPower @params)
        {
            return _client.CallFunction<ResultOfModularPower>(Consts.Commands.ModularPower, @params);
        }

        public Task<ResultOfTonCrc16> TonCrc16(ParamsOfTonCrc16 @params)
        {
            return _client.CallFunction<ResultOfTonCrc16>(Consts.Commands.TonCrc16, @params);
        }

        public Task<ResultOfGenerateRandomBytes> GenerateRandomBytes(
            ParamsOfGenerateRandomBytes @params)
        {
            return _client.CallFunction<ResultOfGenerateRandomBytes>(
                    Consts.Commands.GenerateRandomBytes,
                    @params);
        }

        public Task<ResultOfConvertPublicKeyToTonSafeFormat> ConvertPublicKeyToTonSafeFormat(
            ParamsOfConvertPublicKeyToTonSafeFormat @params)
        {
            return _client.CallFunction<ResultOfConvertPublicKeyToTonSafeFormat>(
                    Consts.Commands.ConvertPublicKeyToTonSafeFormat,
                    @params);
        }

        public Task<KeyPair> GenerateRandomSignKeys()
        {
            return _client.CallFunction<KeyPair>(Consts.Commands.GenerateRandomSignKeys);
        }

        public Task<ResultOfSign> Sign(ParamsOfSign @params)
        {
            return _client.CallFunction<ResultOfSign>(Consts.Commands.Sign, @params);
        }

        public Task<ResultOfVerifySignature> VerifySignature(ParamsOfVerifySignature @params)
        {
            return _client.CallFunction<ResultOfVerifySignature>(Consts.Commands.VerifySignature, @params);
        }

        public Task<ResultOfHash> Sha256(ParamsOfHash @params)
        {
            return _client.CallFunction<ResultOfHash>(Consts.Commands.Sha256, @params);
        }

        public Task<ResultOfHash> Sha512(ParamsOfHash @params)
        {
            return _client.CallFunction<ResultOfHash>(Consts.Commands.Sha512, @params);
        }

        public Task<ResultOfScrypt> Scrypt(ParamsOfScrypt @params)
        {
            return _client.CallFunction<ResultOfScrypt>(Consts.Commands.Scrypt, @params);
        }

        public Task<ResultOfNaclSignDetachedVerify> NaclSignDetachedVerify(ParamsOfNaclSignDetachedVerify @params)
        {
            return _client.CallFunction<ResultOfNaclSignDetachedVerify>(Consts.Commands.NaclSignDetachedVerify, @params);
        }

        public Task<KeyPair> NaclSignKeypairFromSecretKey(ParamsOfNaclSignKeyPairFromSecret @params)
        {
            return _client.CallFunction<KeyPair>(Consts.Commands.NaclSignKeypairFromSecretKey, @params);
        }

        public Task<ResultOfNaclSign> NaclSign(ParamsOfNaclSign @params)
        {
            return _client.CallFunction<ResultOfNaclSign>(Consts.Commands.NaclSign, @params);
        }

        public Task<ResultOfNaclSignOpen> NaclSignOpen(ParamsOfNaclSignOpen @params)
        {
            return _client.CallFunction<ResultOfNaclSignOpen>(Consts.Commands.NaclSignOpen, @params);
        }

        public Task<ResultOfNaclSignDetached> NaclSignDetached(ParamsOfNaclSign @params)
        {
            return _client.CallFunction<ResultOfNaclSignDetached>(Consts.Commands.NaclSignDetached, @params);
        }

        public Task<KeyPair> NaclBoxKeypair()
        {
            return _client.CallFunction<KeyPair>(Consts.Commands.NaclBoxKeypair);
        }

        public Task<KeyPair> NaclBoxKeypairFromSecretKey(ParamsOfNaclBoxKeyPairFromSecret @params)
        {
            return _client.CallFunction<KeyPair>(Consts.Commands.NaclBoxKeypairFromSecretKey, @params);
        }

        public Task<ResultOfNaclBox> NaclBox(ParamsOfNaclBox @params)
        {
            return _client.CallFunction<ResultOfNaclBox>(Consts.Commands.NaclBox, @params);
        }

        public Task<ResultOfNaclBoxOpen> NaclBoxOpen(ParamsOfNaclBoxOpen @params)
        {
            return _client.CallFunction<ResultOfNaclBoxOpen>(Consts.Commands.NaclBoxOpen, @params);
        }

        public Task<ResultOfNaclBox> NaclSecretBox(ParamsOfNaclSecretBox @params)
        {
            return _client.CallFunction<ResultOfNaclBox>(Consts.Commands.NaclSecretBox, @params);
        }

        public Task<ResultOfNaclBoxOpen> NaclSecretBoxOpen(ParamsOfNaclSecretBoxOpen @params)
        {
            return _client.CallFunction<ResultOfNaclBoxOpen>(Consts.Commands.NaclSecretBoxOpen, @params);
        }

        public Task<ResultOfMnemonicWords> MnemonicWords(ParamsOfMnemonicWords @params)
        {
            return _client.CallFunction<ResultOfMnemonicWords>(Consts.Commands.MnemonicWords, @params);
        }

        public Task<ResultOfMnemonicFromRandom> MnemonicFromRandom(ParamsOfMnemonicFromRandom @params)
        {
            return _client.CallFunction<ResultOfMnemonicFromRandom>(Consts.Commands.MnemonicFromRandom, @params);
        }

        public Task<ResultOfMnemonicFromEntropy> MnemonicFromEntropy(ParamsOfMnemonicFromEntropy @params)
        {
            return _client.CallFunction<ResultOfMnemonicFromEntropy>(Consts.Commands.MnemonicFromEntropy, @params);
        }

        public Task<ResultOfMnemonicVerify> MnemonicVerify(ParamsOfMnemonicVerify @params)
        {
            return _client.CallFunction<ResultOfMnemonicVerify>(Consts.Commands.MnemonicVerify, @params);
        }

        public Task<KeyPair> MnemonicDeriveSignKeys(ParamsOfMnemonicDeriveSignKeys @params)
        {
            return _client.CallFunction<KeyPair>(Consts.Commands.MnemonicDeriveSignKeys, @params);
        }

        public Task<ResultOfHDKeyXPrvFromMnemonic> HDKeyXPrvFromMnemonic(ParamsOfHDKeyXPrvFromMnemonic @params)
        {
            return _client.CallFunction<ResultOfHDKeyXPrvFromMnemonic>(Consts.Commands.HDKeyXPrvFromMnemonic, @params);
        }

        public Task<ResultOfHDKeyDeriveFromXPrv> HDKeyDeriveFromXPrv(ParamsOfHDKeyDeriveFromXPrv @params)
        {
            return _client.CallFunction<ResultOfHDKeyDeriveFromXPrv>(Consts.Commands.HDKeyDeriveFromXPrv, @params);
        }

        public Task<ResultOfHDKeyDeriveFromXPrvPath> HDKeyDeriveFromXPrvPath(ParamsOfHDKeyDeriveFromXPrvPath @params)
        {
            return _client.CallFunction<ResultOfHDKeyDeriveFromXPrvPath>(Consts.Commands.HDKeyDeriveFromXPrvPath, @params);
        }

        public Task<ResultOfHDKeySecretFromXPrv> HDKeySecretFromXPrv(ParamsOfHDKeySecretFromXPrv @params)
        {
            return _client.CallFunction<ResultOfHDKeySecretFromXPrv>(Consts.Commands.HDKeySecretFromXPrv, @params);
        }

        public Task<ResultOfHDKeyPublicFromXPrv> HDKeyPublicFromXPrv(ParamsOfHDKeyPublicFromXPrv @params)
        {
            return _client.CallFunction<ResultOfHDKeyPublicFromXPrv>(Consts.Commands.HDKeyPublicFromXPrv, @params);
        }

        public Task<ResultOfHDKeyPublicFromXPrv> Chacha20(ParamsOfHDKeyPublicFromXPrv @params)
        {
            return _client.CallFunction<ResultOfHDKeyPublicFromXPrv>(Consts.Commands.Chacha20, @params);
        }

        public Task<RegisteredSigningBox> RegisterSigningBox(Action<JsonElement, uint> callback = null)
        {
            return _client.CallFunction<RegisteredSigningBox>(Consts.Commands.RegisterSigningBox, callback);
        }

        public Task<RegisteredSigningBox> GetSigningBox(KeyPair @params)
        {
            return _client.CallFunction<RegisteredSigningBox>(Consts.Commands.GetSigningBox, @params);
        }

        public Task<ResultOfSigningBoxGetPublicKey> SigningBoxGetPublicKey(RegisteredSigningBox @params)
        {
            return _client.CallFunction<ResultOfSigningBoxGetPublicKey>(Consts.Commands.SigningBoxGetPublicKey, @params);
        }

        public Task<ResultOfSigningBoxSign> SigningBoxSign(ParamsOfSigningBoxSign @params)
        {
            return _client.CallFunction<ResultOfSigningBoxSign>(Consts.Commands.SigningBoxSign, @params);
        }

        public Task RemoveSigningBox(RegisteredSigningBox @params)
        {
            return _client.CallFunction<RegisteredSigningBox>(Consts.Commands.RemoveSigningBox, @params);
        }

        public async Task<RegisteredEncryptionBox> RegisterEncryptionBox(Func<ParamsOfAppEncryptionBox, Task<ResultOfAppEncryptionBox>> callback)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveEncryptionBox(RegisteredEncryptionBox @params)
        {
            await _client.CallFunction(Consts.Commands.RemoveEncryptionBox, @params);
        }

        public async Task<ResultOfEncryptionBoxGetInfo> EncryptionBoxGetInfo(ParamsOfEncryptionBoxGetInfo @params)
        {
            return await _client.CallFunction<ResultOfEncryptionBoxGetInfo>(Consts.Commands.EncryptionBoxGetInfo, @params);
        }

        public async Task<ResultOfEncryptionBoxEncrypt> EncryptionBoxEncrypt(ParamsOfEncryptionBoxEncrypt @params)
        {
            return await _client.CallFunction<ResultOfEncryptionBoxEncrypt>(Consts.Commands.EncryptionBoxEncrypt, @params);
        }

        public async Task<ResultOfEncryptionBoxDecrypt> EncryptionBoxDecrypt(ParamsOfEncryptionBoxDecrypt @params)
        {
            return await _client.CallFunction<ResultOfEncryptionBoxDecrypt>(Consts.Commands.EncryptionBoxDecrypt, @params);
        }
    }
}
