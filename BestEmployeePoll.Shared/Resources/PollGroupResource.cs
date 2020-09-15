using RestApi.Shared.Resources;

namespace BestEmployeePoll.Shared.Resources
{
    public class PollGroupResource : Resource
    {
        public string[] Employees { get; set; }
    }
}