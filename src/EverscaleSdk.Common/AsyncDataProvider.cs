using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EverscaleSdk.Common
{
    public class AsyncDataStream<T> : IAsyncEnumerable<T>
        where T : class
    {
        private readonly Func<Task<AsyncIterationItem<T>>> _resultGetter;
        private readonly Func<Task> _onDispose;

        public AsyncDataStream(
            Func<Task<AsyncIterationItem<T>>> resultGetter,
            Func<Task> onDispose)
        {
            _resultGetter = resultGetter;
            _onDispose = onDispose;
        }

        public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return new AsyncDataEnumerator(_resultGetter, _onDispose, cancellationToken);
        }

        private class AsyncDataEnumerator : IAsyncEnumerator<T>
        {
            private readonly Func<Task<AsyncIterationItem<T>>> _resultGetter;
            private readonly Func<Task> _onDispose;
            private readonly CancellationToken _ct;

            public T Current { get; private set; }

            public AsyncDataEnumerator(
                Func<Task<AsyncIterationItem<T>>> resultGetter,
                Func<Task> onDispose,
                CancellationToken ct)
            {
                _resultGetter = resultGetter;
                _onDispose = onDispose;
                _ct = ct;
            }

            public async ValueTask<bool> MoveNextAsync()
            {
                this._ct.ThrowIfCancellationRequested();
                var iterationItem = await _resultGetter.Invoke().ConfigureAwait(false);
                this.Current = iterationItem.Result;

                if (iterationItem.IsFinished)
                {
                    return false;
                }

                return true;
            }

            public ValueTask DisposeAsync()
            {
                return new ValueTask(_onDispose());
            }
        }
    }

    public class AsyncIterationItem<T> 
        where T : class
    {
        public AsyncIterationItem(
            T? result,
            Task<AsyncIterationItem<T>>? next,
            bool isFinished)
        {
            Result = result;
            Next = next;
            IsFinished = isFinished;
        }

        public T? Result { get; }
        public Task<AsyncIterationItem<T>>? Next { get; }
        public bool IsFinished { get; }
    }
}
