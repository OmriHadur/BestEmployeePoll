using BestEmployeePoll.Shared.Resources;
using BestEmployeePoll.Standard.Client.Interfaces;
using RestApi.Client.Clients;

namespace BestEmployeePoll.Standard.Client.Clients
{
    public class VoteControllClient :
        RestClient<VoteCreateResource, VoteResource>,
        IVoteControllClient
    {
        public VoteControllClient()
            :base("api/Vote")
        {
        }
    }
}
