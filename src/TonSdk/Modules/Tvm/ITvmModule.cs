using System.Threading.Tasks;
using TonSdk.Modules.Tvm.Models;

namespace TonSdk.Modules.Tvm
{
    public interface ITvmModule
    {
        Task<ResultOfRunExecutor> RunExecutor<AbiType>(ParamsOfRunExecutor<AbiType> @params);

        Task<ResultOfRunTvm> RunTvm<AbiType>(ParamsOfRunTvm<AbiType> @params);

        /// <summary>
        /// Executes getmethod and returns data from TVM stack.
        /// </summary>
        Task<ResultOfRunGet> RunGet(ParamsOfRunGet @params);
    }
}
