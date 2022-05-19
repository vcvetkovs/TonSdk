using System.Threading.Tasks;
using TonSdk.Modules.Proofs.Models;

namespace TonSdk.Modules.Proofs
{
	internal class ProofsModule : IProofsModule
	{
		private readonly TonClient _client;

		public ProofsModule(TonClient client)
		{
			_client = client;
		}

		public Task ProofBlockData(ParamsOfProofBlockData @params)
		{
			return _client
				.CallFunction(Consts.Commands.ProofBlockData, @params);
		}

		public Task ProofTransactionData(ParamsOfProofTransactionData @params)
		{
			return _client
				.CallFunction(Consts.Commands.ProofTransactionData, @params);
		}

		public Task ProofMessageData(ParamsOfProofMessageData @params)
		{
			return _client
				.CallFunction(Consts.Commands.ProofMessageData, @params);
		}
	}
}

