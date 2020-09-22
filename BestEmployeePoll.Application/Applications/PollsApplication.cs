using BestEmployeePoll.Common.Applications;
using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Shared.Errors;
using BestEmployeePoll.Shared.Resources;
using Microsoft.AspNetCore.Mvc;
using RestApi.Application;
using RestApi.Common;
using System.Threading.Tasks;

namespace BestEmployeePoll.Application
{
    [Inject]
    public class PollsApplication : RestApplication<PollCreateResource, PollResource, PollEntity>, IPollsApplication
    {
        public async override Task<ActionResult<PollResource>> Create(PollCreateResource createResource)
        {
            if (createResource.End <= createResource.Starts)
                return BadRequest(BadRequestReasonExtended.EndBeforeStart);
            return await base.Create(createResource);
        }
    }
}
