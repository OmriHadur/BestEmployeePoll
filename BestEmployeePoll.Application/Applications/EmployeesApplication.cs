using BestEmployeePoll.Common.Applications;
using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Shared.Errors;
using BestEmployeePoll.Shared.Resources;
using Microsoft.AspNetCore.Mvc;
using Core.Server.Application;
using Core.Server.Common;
using Core.Server.Shared.Errors;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BestEmployeePoll.Application
{
    [Inject]
    public class EmployeesApplication : RestApplication<EmployeeCreateResource, EmployeeResource, EmployeeEntity>, IEmployeesApplication
    {
        public async override Task<ActionResult<EmployeeResource>> Create(EmployeeCreateResource createResource)
        {
            var emailExists = await Repository.Exists(p => p.Email.Equals(createResource.Email));
            if (emailExists)
                return BadRequest(BadRequestReason.SameExists);

            EmployeeEntity manager = null;
            if (!string.IsNullOrEmpty(createResource.Manager))
            {
                manager = await Repository.Get(createResource.Manager);
                if (manager == null)
                    return NotFound(createResource.Manager);
            }
            var result = await base.Create(createResource);
            if (result.Value != null)
                await AddToManagerStaff(manager, result);
            
            return result;
        }

        protected async override Task<ActionResult> DeleteEntity(EmployeeEntity entity)
        {
            if (entity.Staff?.Count > 0)
                return BadRequest(BadRequestReasonExtended.ManagerHasStaff);
            if (!string.IsNullOrEmpty(entity.Manager))
            {
                var manger = await Repository.Get(entity.Manager);
                manger.Staff.Remove(entity.Id);
                await Repository.Update(manger);
            }
            return await base.DeleteEntity(entity);
        }

        private async Task AddToManagerStaff(EmployeeEntity manager, ActionResult<EmployeeResource> result)
        {
            if (manager != null)
            {
                if (manager.Staff == null)
                    manager.Staff = new List<string>();
                manager.Staff.Add(result.Value.Id);
                await Repository.Update(manager);
            }
        }
    }
}
