using BestEmployeePoll.Shared.Resources;
using BestEmployeePoll.Standard.Client.Interfaces;
using RestApi.Client.Clients;

namespace BestEmployeePoll.Standard.Client.Clients
{
    public class PollVotesControllClient :
        RestClient<PollVoteCreateResource, PollVoteResource>,
        IPollVotesControllClient
    {
        public PollVotesControllClient()
            :base("PollVotes")
        {
        }
    }
}
