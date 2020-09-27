using System.ComponentModel.DataAnnotations;
using Core.Server.Common.Entities;

namespace BestEmployeePoll.Common.Entities
{
    public class PollGroupEntity : Entity
    {
        [Required]
        public string PollId { get; set; }
        public string[] Employees { get; set; }
    }
}
