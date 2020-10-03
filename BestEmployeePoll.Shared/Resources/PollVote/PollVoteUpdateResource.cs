using Core.Server.Shared.Resources;

namespace BestEmployeePoll.Shared.Resources
{
    public class PollVoteUpdateResource : UpdateResource
    {
        public string VotedEmployeeId { get; set; }
    }
}