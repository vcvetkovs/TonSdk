using System;
using System.Threading.Tasks;
using EverscaleSdk.Common;
using EverscaleSdk.Interop.Enums;
using EverscaleSdk.Interop.Models;

namespace EverscaleSdk
{
    public partial interface IEverscaleClient : IDisposable
    {
        Task CallFunction(string functionName, object? paramsJson = null);
        Task<T> CallFunction<T>(string functionName, object? paramsJson = null);
        Task<T> CallFunction<T, TCallback>(string functionName, object? paramsJson = null, Action<TCallback, FunctionExecutionStatus> callack = null, Func<string, Task> func = null);
        ResultOfFunctionCall<T> CallFunctionSync<T>(string name, object? paramsJson = null);
        AsyncDataStream<string> SubscribeToFunction<T>(string methodName, object paramsJson, Func<T, Task> onDispose);
    }
}
