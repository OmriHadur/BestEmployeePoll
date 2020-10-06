using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Shared.Errors;
using BestEmployeePoll.Shared.Resources;
using Core.Server.Common;
using Core.Server.Common.Validators;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Unity;

namespace BestEmployeePoll.Application.Validators
{
    [Inject]
    public class PollValidator
        :  ResourceValidator<PollCreateResource, PollUpdateResource, PollEntity>
    {
        public async override Task<ActionResult> Validate(PollCreateResource resource)
        {
            if (resource.End <= resource.Starts)
                return BadRequest(BadRequestReasonExtended.EndBeforeStart);
            return await base.Validate(resource);
        }
    }
}
