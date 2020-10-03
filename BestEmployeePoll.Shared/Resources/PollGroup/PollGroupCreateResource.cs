using Core.Server.Shared.Resources;
using System.ComponentModel.DataAnnotations;

namespace BestEmployeePoll.Shared.Resources
{
    public class PollGroupCreateResource : CreateResource
    {
        [Required]
        public string PollId { get; set; }
    }
}