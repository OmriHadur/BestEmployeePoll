using Core.Server.Tests.ResourceCreators;
using BestEmployeePoll.Shared.Resources;

namespace BestEmployeePoll.Test.ResourceCreators
{
    public class PollVoteResourceCreator : RestResourceCreator<PollVoteCreateResource, PollVoteResource>
    {
        public override void SetCreateResource(PollVoteCreateResource createResource)
        {
            base.SetCreateResource(createResource);
            createResource.PollId = GetResourceId<PollResource>();
            createResource.EmployeeId = GetResourceId<EmployeeResource>();
        }
    }
}
