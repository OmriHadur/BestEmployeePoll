using BestEmployeePoll.Shared.Resources;
using BestEmployeePoll.Standard.Client.Interfaces;
using RestApi.Client.Clients;

namespace BestEmployeePoll.Standard.Client.Clients
{
    public class EmployeesControllClient :
        RestClient<EmployeeCreateResource, EmployeeResource>,
        IEmployeesControllClient
    {
        public EmployeesControllClient()
            :base("Employees")
        {
        }
    }
}
