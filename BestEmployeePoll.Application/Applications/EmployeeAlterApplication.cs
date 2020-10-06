using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Shared.Errors;
using BestEmployeePoll.Shared.Resources;
using Microsoft.AspNetCore.Mvc;
using Core.Server.Application;
using Core.Server.Common;
using System.Threading.Tasks;

namespace BestEmployeePoll.Application
{
    [Inject]
    public class EmployeeAlterApplication : 
        AlterApplication<EmployeeCreateResource, EmployeeUpdateResource, EmployeeResource, EmployeeEntity>
    {
        protected async override Task<ActionResult> DeleteEntity(EmployeeEntity entity)
        {
            if (entity.Staff?.Count > 0)
                return BadRequest(BadRequestReasonExtended.ManagerHasStaff);
            if (!string.IsNullOrEmpty(entity.Manager))
            {
                var manger = await QueryRepository.Get(entity.Manager);
                manger.Staff.Remove(entity.Id);
                await AlterRepository.Update(manger);
            }
            return await base.DeleteEntity(entity);
        }
    }
}
