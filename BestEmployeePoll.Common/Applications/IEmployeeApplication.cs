using BestEmployeePoll.Shared.Resources;
using Core.Server.Common.Applications;

namespace BestEmployeePoll.Common.Applications
{
    public interface IEmployeeApplication : 
        IRestApplication<EmployeeCreateResource, EmployeeUpdateResource, EmployeeResource>
    {
    }
}
