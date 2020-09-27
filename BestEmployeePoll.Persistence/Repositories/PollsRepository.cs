using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Common.Repositories;
using Core.Server.Persistence.Repositories;
using Core.Server.Common;

namespace BestEmployeePoll.Persistence.Repositories
{
    [Inject]
    public class PollsRepository : MongoRepository<PollEntity>, IPollsRepository
    {
    }
}