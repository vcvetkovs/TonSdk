using TonSdk.Modules.Processing;

namespace TonSdk.Tests
{
    public class ProcessingModuleTests
    {
        private readonly IProcessingModule _sut;

        public ProcessingModuleTests()
        {
            _sut = new TonClient().Processing;
        }
    }
}
