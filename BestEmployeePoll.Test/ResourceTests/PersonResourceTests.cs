using Microsoft.VisualStudio.TestTools.UnitTesting;
using BestEmployeePoll.Shared.Resources;
using RestApi.Tests.ResourceTests;

namespace BestEmployeePoll.Tests.RourcesTests
{
    [TestClass]
    public class PersonResourceTests : ResourceTests<PersonCreateResource, PersonResource>
    {
    }
}
