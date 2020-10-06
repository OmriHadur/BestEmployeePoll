using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Shared.Resources;
using Core.Server.Application.Mappers.Base;
using Core.Server.Common;
using Core.Server.Common.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity;

namespace BestEmployeePoll.Application.Mappers
{
    [Inject]
    public class EmployeeAlterResourceMapper
        : AlterResourceMapper<EmployeeCreateResource, EmployeeUpdateResource, EmployeeResource, EmployeeEntity>
    {
        [Dependency]
        public IQueryRepository<EmployeeEntity> QueryRepository;

        [Dependency]
        public IAlterRepository<EmployeeEntity> AlterRepository;

        public override async Task<EmployeeEntity> Map(EmployeeCreateResource resource)
        {
            var employeeEntity = await base.Map(resource);
            await AddToManagerStaff(resource, employeeEntity);
            return employeeEntity;
        }

        private async Task AddToManagerStaff(EmployeeCreateResource resource, EmployeeEntity employeeResource)
        {
            if (string.IsNullOrEmpty(resource.ManagerId)) 
                return;
            var managerEntity = await QueryRepository.Get(resource.ManagerId);
            if (managerEntity.Staff == null)
                managerEntity.Staff = new List<string>();
            managerEntity.Staff.Add(employeeResource.Id);
            await AlterRepository.Update(managerEntity);
        }
    }
}
