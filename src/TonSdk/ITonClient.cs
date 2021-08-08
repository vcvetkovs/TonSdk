﻿using System;
using System.Threading.Tasks;
using TonSdk.Common;
using TonSdk.Interop.Enums;
using TonSdk.Interop.Models;

namespace TonSdk
{
    public partial interface ITonClient : IDisposable
    {
        Task CallFunction(string functionName, object? paramsJson = null);
        Task<T> CallFunction<T>(string functionName, object? paramsJson = null);
        Task<T> CallFunction<T, TCallback>(string functionName, object? paramsJson = null, Action<TCallback, FunctionExecutionStatus> callack = null, Func<string, Task> func = null);
        ResultOfFunctionCall<T> CallFunctionSync<T>(string name, object? paramsJson = null);
        AsyncDataStream<string> SubscribeToFunction<T>(string methodName, object paramsJson, Func<T, Task> onDispose);
    }
}
