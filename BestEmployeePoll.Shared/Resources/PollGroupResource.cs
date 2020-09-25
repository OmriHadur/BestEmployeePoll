using RestApi.Shared.Resources;

namespace BestEmployeePoll.Shared.Resources
{
    public class PollGroupResource : Resource
    {
        public string PollId { get; set; }
        public string[] Employees { get; set; }
    }
}