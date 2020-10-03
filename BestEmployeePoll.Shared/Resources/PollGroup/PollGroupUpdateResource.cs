using Core.Server.Shared.Resources;
using System.ComponentModel.DataAnnotations;

namespace BestEmployeePoll.Shared.Resources
{
    public class PollGroupUpdateResource : UpdateResource
    {
        public string PollId { get; set; }
    }
}