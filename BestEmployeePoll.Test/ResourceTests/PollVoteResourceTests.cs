using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Server.Tests.ResourceTests;
using BestEmployeePoll.Shared.Resources;

namespace BestEmployeePoll.Tests.RourcesTests
{
    [TestClass]
    public class PollVoteResourceTests : 
        ResourceTests<PollVoteCreateResource,PollVoteUpdateResource, PollVoteResource>
    {
    }
}
