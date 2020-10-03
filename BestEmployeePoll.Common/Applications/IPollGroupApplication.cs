using BestEmployeePoll.Shared.Resources;
using Core.Server.Common.Applications;
using System.Threading.Tasks;

namespace BestEmployeePoll.Common.Applications
{
    public interface IPollGroupApplication : 
        IRestApplication<PollGroupCreateResource, PollGroupUpdateResource, PollGroupResource>
    {
        Task<bool> AreInSameVoteGroup(string pollId, params string[] emplyees);
    }
}
