using BestEmployeePoll.Shared.Resources;
using RestApi.Common.Applications;

namespace BestEmployeePoll.Common.Applications
{
    public interface IEmployeesApplication : IRestApplication<EmployeeCreateResource, EmployeeResource>
    {
    }
}