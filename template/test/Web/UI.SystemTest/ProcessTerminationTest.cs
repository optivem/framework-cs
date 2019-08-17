using Optivem.Framework.Test.AspNetCore;
using Xunit;

namespace Optivem.Template.Web.RestApi.IntegrationTest
{
    // TODO: VC: When testing, making equivalent tests for application layer and web layer when testing correctness
    // and on web layer just see that it returns web specific things (e.g. status codes)

    public class ProcessTerminationTest
    {

        [Fact(Skip = "Currently runs just locally, can do test with hosting site...")]
        public void TestTerminate()
        {
            WebPortProcessFinder finder = new WebPortProcessFinder();
            var processId = finder.FindProcessId(5103);
            Assert.NotNull(processId);

            ProcessTerminator terminator = new ProcessTerminator();
            terminator.Terminate(processId.Value);

            Assert.Null(finder.FindProcessId(5103));

        }


    }
}