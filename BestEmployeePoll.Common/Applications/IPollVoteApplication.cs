using BestEmployeePoll.Shared.Resources;
using Core.Server.Common.Applications;

namespace BestEmployeePoll.Common.Applications
{
    public interface IPollVoteApplication : 
        IRestApplication<PollVoteCreateResource, PollVoteUpdateResource, PollVoteResource>
    {
    }
}
