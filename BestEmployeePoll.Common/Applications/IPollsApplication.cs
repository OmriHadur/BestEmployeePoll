using BestEmployeePoll.Shared.Resources;
using Core.Server.Common.Applications;

namespace BestEmployeePoll.Common.Applications
{
    public interface IPollsApplication : IRestApplication<PollCreateResource, PollResource>
    {
    }
}
