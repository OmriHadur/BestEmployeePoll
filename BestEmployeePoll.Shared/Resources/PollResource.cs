using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using RestApi.Shared.Resources;
using System;

namespace BestEmployeePoll.Shared.Resources
{
    public class PollResource : Resource
    {
        public DateTime Starts { get; set; }

        public DateTime End { get; set; }
    }
}