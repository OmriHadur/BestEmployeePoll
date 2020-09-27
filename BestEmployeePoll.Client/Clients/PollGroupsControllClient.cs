using BestEmployeePoll.Shared.Resources;
using BestEmployeePoll.Standard.Client.Interfaces;
using Core.Server.Client.Clients;

namespace BestEmployeePoll.Standard.Client.Clients
{
    public class PollGroupsControllClient :
        RestClient<PollGroupCreateResource, PollGroupResource>,
        IPollGroupsControllClient
    {
        public PollGroupsControllClient()
            :base("PollGroups")
        {
        }
    }
}
