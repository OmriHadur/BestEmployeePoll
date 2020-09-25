using System;
using RestApi.Common.Entities;

namespace BestEmployeePoll.Common.Entities
{
    public class PollEntity : Entity
    {
        public DateTime Starts { get; set; }

        public DateTime End { get; set; }
    }
}
