using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Shared.Resources;
using Core.Server.Common;
using Core.Server.Common.Repositories;
using Core.Server.Common.Validators;
using Core.Server.Shared.Errors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Unity;

namespace BestEmployeeEmployee.Application.Validators
{
    [Inject]
    public class EmployeeValidator
        : ResourceValidator<EmployeeCreateResource, EmployeeUpdateResource, EmployeeEntity>
    {
        [Dependency]
        public IQueryRepository<EmployeeEntity> QueryRepository;

        public async override Task<ActionResult> Validate(EmployeeCreateResource resource)
        {
            var emailExists = await QueryRepository.Exists(p => p.Email.Equals(resource.Email));
            if (emailExists)
                return BadRequest(BadRequestReason.SameExists);
            if (!string.IsNullOrEmpty(resource.ManagerId))
            {
                var managerExists = await QueryRepository.Exists(resource.ManagerId);
                if (!managerExists)
                    return NotFound(resource.ManagerId);
            }
            return await base.Validate(resource);
        }
    }
}
