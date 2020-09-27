using Core.Server.Tests.ResourceCreators;
using BestEmployeePoll.Shared.Resources;

namespace BestEmployeePoll.Test.ResourceCreators
{
    public class PollResourceCreator : RestResourceCreator<PollCreateResource, PollResource>
    {
        public override void SetCreateResource(PollCreateResource createResource)
        {
            base.SetCreateResource(createResource);
            createResource.End = createResource.Starts.AddDays(1);
        }
    }
}
