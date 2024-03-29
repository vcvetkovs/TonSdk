﻿using System;
using System.Threading.Tasks;
using EverscaleSdk.Modules.Boc.Models;

namespace EverscaleSdk.Modules.Boc
{
    public class BocModule : IBocModule
    {
        private readonly IEverscaleClient _client;

        public BocModule(IEverscaleClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public Task<ResultOfParse> ParseMessage(ParamsOfParse @params)
        {
            return _client
                .CallFunction<ResultOfParse>(Consts.Commands.ParseMessage, @params);
        }

        public Task<ResultOfParse> ParseTransaction(ParamsOfParse @params)
        {
            return _client
                .CallFunction<ResultOfParse>(Consts.Commands.ParseTransaction, @params);
        }

        public Task<ResultOfParse> ParseAccount(ParamsOfParse @params)
        {
            return _client
                .CallFunction<ResultOfParse>(Consts.Commands.ParseAccount, @params);
        }

        public Task<ResultOfParse> ParseBlock(ParamsOfParse @params)
        {
            return _client
                .CallFunction<ResultOfParse>(Consts.Commands.ParseBlock, @params);
        }

        public Task<ResultOfParse> ParseShardState(ParamsOfParseShardState @params)
        {
            return _client.CallFunction<ResultOfParse>(Consts.Commands.ParseShardState, @params);
        }

        public Task<ResultOfParse> ParseShardstate(ParamsOfParseShardState @params)
        {
            return _client.CallFunction<ResultOfParse>(Consts.Commands.ParseShardState, @params);
        }

        public Task<ResultOfGetBlockchainConfig> GetBlockchainConfig(ParamsOfGetBlockchainConfig @params)
        {
            return _client
                .CallFunction<ResultOfGetBlockchainConfig>(Consts.Commands.GetBlockchainConfig, @params);
        }

        public Task<ResultOfGetBocHash> GetBocHash(ParamsOfGetBocHash @params)
        {
            return _client
                .CallFunction<ResultOfGetBocHash>(Consts.Commands.GetBocHash, @params);
        }

        public Task<ResultOfGetBocDepth> GetBocDepth(ParamsOfGetBocDepth @params)
        {
            return _client
                .CallFunction<ResultOfGetBocDepth>(Consts.Commands.GetBocDepth, @params);
        }

        public Task<ResultOfGetCodeFromTvc> GetCodeFromTvc(ParamsOfGetCodeFromTvc @params)
        {
            return _client
                .CallFunction<ResultOfGetCodeFromTvc>(Consts.Commands.GetCodeFromTvc, @params);
        }

        public Task<ResultOfBocCacheGet> CacheGet(ParamsOfBocCacheGet @params)
        {
            return _client
                .CallFunction<ResultOfBocCacheGet>(Consts.Commands.CacheGet, @params);
        }

        public Task<ResultOfBocCacheSet> CacheSet(ParamsOfBocCacheSet @params)
        {
            return _client
                .CallFunction<ResultOfBocCacheSet>(Consts.Commands.CacheSet, @params);
        }

        public Task CacheUnpin(ParamsOfBocCacheUnpin @params)
        {
            return _client
                .CallFunction(Consts.Commands.CacheUnpin, @params);
        }

        public Task<ResultOfEncodeBoc> EncodeBoc(ParamsOfEncodeBoc @params)
        {
            return _client
                .CallFunction<ResultOfEncodeBoc>(Consts.Commands.EncodeBoc, @params);
        }

        public Task<ResultOfGetCodeSalt> GetCodeSalt(ParamsOfGetCodeSalt @params)
        {
            return _client
                .CallFunction<ResultOfGetCodeSalt>(Consts.Commands.GetCodeSalt, @params);
        }

        public Task<ResultOfSetCodeSalt> SetCodeSalt(ParamsOfSetCodeSalt @params)
        {
            return _client
                .CallFunction<ResultOfSetCodeSalt>(Consts.Commands.SetCodeSalt, @params);
        }

        public Task<ResultOfDecodeTvc> DecodeTvc(ParamsOfDecodeTvc @params)
        {
            return _client
                .CallFunction<ResultOfDecodeTvc>(Consts.Commands.DecodeTvc, @params);
        }

        public Task<ResultOfEncodeTvc> EncodeTvc(ParamsOfEncodeTvc @params)
        {
            return _client
                .CallFunction<ResultOfEncodeTvc>(Consts.Commands.EncodeTvc, @params);
        }

        public Task<ResultOfGetCompilerVersion> GetCompilerVersion(ParamsOfGetCompilerVersion @params)
        {
            return _client
                .CallFunction<ResultOfGetCompilerVersion>(Consts.Commands.GetCompilerVersion, @params);
        }

        public Task<ResultOfEncodeExternalInMessage> EncodeExternalInMessage(ParamsOfEncodeExternalInMessage @params)
        {
            return _client
                .CallFunction<ResultOfEncodeExternalInMessage>(Consts.Commands.EncodeExternalInMessage, @params);
        }
    }
}
