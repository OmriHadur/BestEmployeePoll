using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Server.Tests.ResourceTests;
using BestEmployeePoll.Shared.Resources;

namespace BestEmployeePoll.Tests.RourcesTests
{
    [TestClass]
    public class PollGroupResourceTests : 
        ResourceTests<PollGroupCreateResource,PollGroupUpdateResource, PollGroupResource>
    {
    }
}
