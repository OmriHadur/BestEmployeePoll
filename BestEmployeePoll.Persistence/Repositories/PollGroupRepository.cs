using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Common.Repositories;
using Core.Server.Persistence.Repositories;
using Core.Server.Common;
using System.Threading.Tasks;
using System.Linq;

namespace BestEmployeePoll.Persistence.Repositories
{
    [Inject]
    public class PollGroupRepository : 
        Repository<PollGroupEntity>, 
        IPollGroupRepository
    {
        public async Task<bool> AreInSameVoteGroup(string pollId, string[] emplyees)
        {
            var group = await FindFirst(p => p.PollId == pollId);
            foreach (var emplyee in emplyees)
                if (!group.Employees.Contains(emplyee))
                    return false;
            return true;
        }
    }
}