using BestEmployeePoll.Common.Applications;
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
    public class PollApplication : 
        RestApplication<PollCreateResource, PollUpdateResource, PollResource, PollEntity>, IPollApplication
    {
        protected async override Task<ActionResult> Validate(PollCreateResource createResource)
        {
            if (createResource.End <= createResource.Starts)
                return BadRequest(BadRequestReasonExtended.EndBeforeStart);
            return await base.Validate(createResource);
        }
    }
}
