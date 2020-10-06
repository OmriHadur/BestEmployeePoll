using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Common.Repositories;
using BestEmployeePoll.Shared.Errors;
using BestEmployeePoll.Shared.Resources;
using Core.Server.Common;
using Core.Server.Common.Validators;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace BestEmployeePoll.Application.Validators
{
    [Inject]
    public class PollVoteValidator
        :  ResourceValidator<PollVoteCreateResource, PollVoteUpdateResource, PollVoteEntity>

    {
        [Dependency]
        public IPollGroupQueryRepository pollGroupQuery;

        public async override Task<ActionResult> Validate(PollVoteCreateResource resource)
        {
            if (!(await IsEntityExists<PollEntity>(resource.PollId)))
                return NotFound(resource.PollId);

            if (!(await IsEntityExists<EmployeeEntity>(resource.EmployeeId)))
                return NotFound(resource.EmployeeId);

            if (!(await IsEntityExists<EmployeeEntity>(resource.VotedEmployeeId)))
                return NotFound(resource.VotedEmployeeId);

            if (await AreInSameVoteGroup(resource))
                return BadRequest(BadRequestReasonExtended.NotSameVoteGroup);

            return await base.Validate(resource);
        }

        private Task<bool> AreInSameVoteGroup(PollVoteCreateResource resource)
        {
            return pollGroupQuery.AreInSameVoteGroup(
                resource.PollId, 
                resource.EmployeeId, 
                resource.VotedEmployeeId);
        }
    }
}
