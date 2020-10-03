using BestEmployeePoll.Shared.Resources;
using BestEmployeePoll.Standard.Client.Interfaces;
using Core.Server.Client.Clients;

namespace BestEmployeePoll.Standard.Client.Clients
{
    public class PollControllClient :
        RestClient<PollCreateResource, PollUpdateResource, PollResource>,
        IPollControllClient
    {
    }
}
