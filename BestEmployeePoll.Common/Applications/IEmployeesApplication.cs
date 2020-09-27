using BestEmployeePoll.Shared.Resources;
using Core.Server.Common.Applications;

namespace BestEmployeePoll.Common.Applications
{
    public interface IEmployeesApplication : IRestApplication<EmployeeCreateResource, EmployeeResource>
    {
    }
}
