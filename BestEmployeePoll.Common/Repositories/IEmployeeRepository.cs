using BestEmployeePoll.Common.Entities;
using Core.Server.Common.Repositories;

namespace BestEmployeePoll.Common.Repositories
{
    public interface IEmployeeRepository : 
        IRepository<EmployeeEntity>
    {
    }
}
