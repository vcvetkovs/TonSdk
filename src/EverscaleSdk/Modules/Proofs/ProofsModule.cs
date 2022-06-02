using System.Threading.Tasks;
using EverscaleSdk.Modules.Proofs.Models;

namespace EverscaleSdk.Modules.Proofs
{
	internal class ProofsModule : IProofsModule
	{
		private readonly EverscaleClient _client;

		public ProofsModule(EverscaleClient client)
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

