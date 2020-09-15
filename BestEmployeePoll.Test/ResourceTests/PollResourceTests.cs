using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestApi.Tests.ResourceTests;
using BestEmployeePoll.Shared.Resources;

namespace BestEmployeePoll.Tests.RourcesTests
{
    [TestClass]
    public class PollResourceTests : ResourceTests<PollCreateResource, PollResource>
    {
    }
}
