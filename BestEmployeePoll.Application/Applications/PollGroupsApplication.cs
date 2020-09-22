using BestEmployeePoll.Common.Applications;
using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Shared.Resources;
using RestApi.Application;
using RestApi.Common;
using System.Threading.Tasks;

namespace BestEmployeePoll.Application
{
    [Inject]
    public class PollGroupsApplication : RestApplication<PollGroupCreateResource, PollGroupResource, PollGroupEntity>, IPollGroupsApplication
    {
        public async Task<bool> AreInSameVoteGroup(string voteId, params string[] emplyees)
        {
            return true;
        }
    }
}
