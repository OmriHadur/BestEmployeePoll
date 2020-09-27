using System.ComponentModel.DataAnnotations;
using Core.Server.Common.Entities;

namespace BestEmployeePoll.Common.Entities
{
    public class PollVoteEntity : Entity
    {
        [Required]
        public string PollId { get; set; }

        [Required]
        public string EmployeeId { get; set; }

        [Required]
        public string VotedEmployeeId { get; set; }
    }
}
