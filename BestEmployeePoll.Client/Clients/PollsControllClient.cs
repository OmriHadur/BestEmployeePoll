using BestEmployeePoll.Shared.Resources;
using BestEmployeePoll.Standard.Client.Interfaces;
using Core.Server.Client.Clients;

namespace BestEmployeePoll.Standard.Client.Clients
{
    public class PollsControllClient :
        RestClient<PollCreateResource, PollResource>,
        IPollsControllClient
    {
        public PollsControllClient()
            :base("Polls")
        {
        }
    }
}
