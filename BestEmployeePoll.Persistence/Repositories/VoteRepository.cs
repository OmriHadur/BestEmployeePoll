using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Common.Repositories;
using RestApi.Persistence.Repositories;
using RestApi.Common;

namespace BestEmployeePoll.Persistence.Repositories
{
    [Inject]
    public class VoteRepository : MongoRepository<VoteEntity>, IVoteRepository
    {
    }
}