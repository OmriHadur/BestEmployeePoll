using BestEmployeePoll.Common.Entities;
using Core.Server.Common.Repositories;
using System.Threading.Tasks;

namespace BestEmployeePoll.Common.Repositories
{
    public interface IPollGroupRepository : 
        IRepository<PollGroupEntity>
    {
        Task<bool> AreInSameVoteGroup(string pollId, string[] emplyees);
    }
}
