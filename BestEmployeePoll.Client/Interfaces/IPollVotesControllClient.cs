using BestEmployeePoll.Shared.Resources;
using RestApi.Client.Interfaces;

namespace BestEmployeePoll.Standard.Client.Interfaces
{
    public interface IPollVotesControllClient : IRestClient<PollVoteCreateResource, PollVoteResource>
    {
    }
}
