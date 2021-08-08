﻿using System;
using System.Threading.Tasks;
using TonSdk.Modules.Debot.Models;

namespace TonSdk.Modules.Debot
{
	internal class DebotModule : IDebotModule
    {
        private readonly TonClient _client;

        internal DebotModule(TonClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public Task<RegisteredDebot> Init(ParamsOfInit @params, Func<ParamsOfAppDebotBrowser, Task<ResultOfAppDebotBrowser>> callback)
        {
            throw new NotImplementedException();
        }

        public Task Start(ParamsOfStart @params)
        {
            return _client.CallFunction(Consts.Commands.Start, @params);
        }

        public Task<ResultOfFetch> Fetch(ParamsOfFetch @params)
        {
            return _client.CallFunction<ResultOfFetch>(Consts.Commands.Fetch, @params);
        }

        public async Task Execute(ParamsOfExecute @params)
        {
            await _client.CallFunction(Consts.Commands.Execute, @params);
        }

        public async Task Send(ParamsOfSend @params)
        {
            await _client.CallFunction(Consts.Commands.Send, @params);
        }

        public async Task Remove(RegisteredDebot @params)
        {
            await _client.CallFunction(Consts.Commands.Remove, @params);
        }
    }
}
