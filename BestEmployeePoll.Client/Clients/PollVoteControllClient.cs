using BestEmployeePoll.Shared.Resources;
using BestEmployeePoll.Standard.Client.Interfaces;
using Core.Server.Client.Clients;

namespace BestEmployeePoll.Standard.Client.Clients
{
    public class PollVoteControllClient :
        RestClient<PollVoteCreateResource, PollVoteUpdateResource, PollVoteResource>,
        IPollVoteControllClient
    {
    }
}
