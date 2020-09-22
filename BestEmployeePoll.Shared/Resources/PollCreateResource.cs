using RestApi.Shared.Resources;
using System;
using System.ComponentModel.DataAnnotations;

namespace BestEmployeePoll.Shared.Resources
{
    public class PollCreateResource : CreateResource
    {
        [Required]
        public DateTime Starts { get; set; }

        [Required]
        public DateTime End { get; set; }
    }
}