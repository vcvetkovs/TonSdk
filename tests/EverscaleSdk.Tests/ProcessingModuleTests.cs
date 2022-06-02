using EverscaleSdk.Modules.Processing;

namespace EverscaleSdk.Tests
{
    public class ProcessingModuleTests
    {
        private readonly IProcessingModule _sut;

        public ProcessingModuleTests()
        {
            _sut = new EverscaleClient().Processing;
        }
    }
}
