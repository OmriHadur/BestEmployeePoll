using BestEmployeePoll.Shared.Resources;
using RestApi.Common.Applications;

namespace BestEmployeePoll.Common.Applications
{
    public interface IPollApplication : IRestApplication<PollCreateResource, PollResource>
    {
    }
}
