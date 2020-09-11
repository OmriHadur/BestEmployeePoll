using BestEmployeePoll.Common.Applications;
using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Shared.Resources;
using RestApi.Application;
using RestApi.Common;

namespace BestEmployeePoll.Application
{
    [Inject]
    public class VoteApplication : RestApplication<VoteCreateResource, VoteResource, VoteEntity>, IVoteApplication
    {
    }
}
