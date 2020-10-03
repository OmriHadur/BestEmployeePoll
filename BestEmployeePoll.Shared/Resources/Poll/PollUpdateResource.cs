using Core.Server.Shared.Resources;
using System;
using System.ComponentModel.DataAnnotations;

namespace BestEmployeePoll.Shared.Resources
{
    public class PollUpdateResource : UpdateResource
    {
        public DateTime Starts { get; set; }

        public DateTime End { get; set; }
    }
}