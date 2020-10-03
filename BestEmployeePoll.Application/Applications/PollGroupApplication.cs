using BestEmployeePoll.Common.Applications;
using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Common.Repositories;
using BestEmployeePoll.Shared.Resources;
using Core.Server.Application;
using Core.Server.Common;
using System.Threading.Tasks;

namespace BestEmployeePoll.Application
{
    [Inject]
    public class PollGroupApplication : 
        RestApplication<PollGroupCreateResource, PollGroupUpdateResource, PollGroupResource, PollGroupEntity>, IPollGroupApplication
    {
        public Task<bool> AreInSameVoteGroup(string pollId, params string[] emplyees)
        {
            return (Repository as IPollGroupRepository).AreInSameVoteGroup(pollId, emplyees);
        }
    }
}
