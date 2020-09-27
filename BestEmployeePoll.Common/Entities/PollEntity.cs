using System;
using Core.Server.Common.Entities;

namespace BestEmployeePoll.Common.Entities
{
    public class PollEntity : Entity
    {
        public DateTime Starts { get; set; }

        public DateTime End { get; set; }
    }
}
