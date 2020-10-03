using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Core.Server.Shared.Resources;

namespace BestEmployeePoll.Shared.Resources
{
    public class PollVoteResource : Resource
    {
        public string PollId { get; set; }

        public string EmployeeId { get; set; }

        public string VotedEmployeeId { get; set; }
    }
}