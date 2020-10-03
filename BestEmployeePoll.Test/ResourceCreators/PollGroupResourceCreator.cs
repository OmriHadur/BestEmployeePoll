using Core.Server.Tests.ResourceCreators;
using BestEmployeePoll.Shared.Resources;

namespace BestEmployeePoll.Test.ResourceCreators
{
    public class PollGroupResourceCreator :
        RestResourceCreator<PollGroupCreateResource,PollGroupUpdateResource, PollGroupResource>
    {
    }
}
