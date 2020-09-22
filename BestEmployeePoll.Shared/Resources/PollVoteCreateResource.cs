using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using RestApi.Shared.Resources;

namespace BestEmployeePoll.Shared.Resources
{
    public class PollVoteCreateResource : CreateResource
    {
        [Required]
        public string PollId { get; set; }

        [Required]
        public string EmployeeId { get; set; }

        [Required]
        public string VotedEmployeeId { get; set; }
    }
}