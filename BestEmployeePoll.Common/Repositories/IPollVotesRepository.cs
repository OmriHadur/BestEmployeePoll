using BestEmployeePoll.Common.Entities;
using RestApi.Common.Repositories;

namespace BestEmployeePoll.Common.Repositories
{
    public interface IPollVotesRepository : IRepository<PollVoteEntity>
    {
    }
}