using BestEmployeePoll.Common.Entities;
using Core.Server.Common.Repositories;
using System.Threading.Tasks;

namespace BestEmployeePoll.Common.Repositories
{
    public interface IPollGroupQueryRepository : 
        IQueryRepository<PollGroupEntity>
    {
        Task<bool> AreInSameVoteGroup(string pollId,params string[] emplyees);
    }
}
