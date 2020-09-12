using BestEmployeePoll.Common.Applications;
using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Shared.Resources;
using Microsoft.AspNetCore.Mvc;
using RestApi.Application;
using RestApi.Common;
using System.Threading.Tasks;

namespace BestEmployeePoll.Application
{
    [Inject]
    public class PersonApplication : RestApplication<PersonCreateResource, PersonResource, PersonEntity>, IPersonApplication
    {
        public async override Task<ActionResult<PersonResource>> Create(PersonCreateResource createResource)
        {
            if (!string.IsNullOrEmpty(createResource.Manager))
                if (!await Repository.Exists(createResource.Manager))
                    return NotFound(createResource.Manager);

            return await base.Create(createResource);
        }
        protected async override Task<PersonResource> Map(PersonEntity entity)
        {
            var resource = await base.Map(entity);
            if (!string.IsNullOrEmpty(entity.Manager))
            {
                var manager = await Repository.Get(entity.Manager);
                resource.Manager = Mapper.Map<PersonResource>(manager);
            }

            var employees = await Repository.Get(entity.Employees);
            resource.Employees = Mapper.Map<PersonResource[]>(employees);

            return resource;
        }
    }
}
