using BestEmployeePoll.Shared.Resources;
using BestEmployeePoll.Standard.Client.Interfaces;
using RestApi.Client.Clients;

namespace BestEmployeePoll.Standard.Client.Clients
{
    public class GroupControllClient :
        RestClient<GroupCreateResource, GroupResource>,
        IGroupControllClient
    {
        public GroupControllClient()
            :base("api/Group")
        {
        }
    }
}
