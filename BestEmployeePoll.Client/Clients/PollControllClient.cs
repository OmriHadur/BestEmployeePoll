using BestEmployeePoll.Shared.Resources;
using BestEmployeePoll.Standard.Client.Interfaces;
using RestApi.Client.Clients;

namespace BestEmployeePoll.Standard.Client.Clients
{
    public class PollControllClient :
        RestClient<PollCreateResource, PollResource>,
        IPollControllClient
    {
        public PollControllClient()
            :base("api/Poll")
        {
        }
    }
}
