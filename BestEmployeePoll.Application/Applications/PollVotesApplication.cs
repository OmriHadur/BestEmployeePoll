using BestEmployeePoll.Common.Applications;
using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Shared.Errors;
using BestEmployeePoll.Shared.Resources;
using Microsoft.AspNetCore.Mvc;
using RestApi.Application;
using RestApi.Common;
using System.Threading.Tasks;
using Unity;

namespace BestEmployeePoll.Application
{
    [Inject]
    public class PollVotesApplication : RestApplication<PollVoteCreateResource, PollVoteResource, PollVoteEntity>, IPollVotesApplication
    {
        [Dependency]
        public IPollGroupsApplication PollGroupsApplication;

        public async override Task<ActionResult<PollVoteResource>> Create(PollVoteCreateResource createResource)
        {
            if (!(await IsEntityExists<PollEntity>(createResource.PollId)))
                return NotFound(createResource.PollId);

            if (!(await IsEntityExists<EmployeeEntity>(createResource.EmployeeId)))
                return NotFound(createResource.EmployeeId);

            if (!(await IsEntityExists<EmployeeEntity>(createResource.VotedEmployeeId)))
                return NotFound(createResource.VotedEmployeeId);

            if (await AreInSameVoteGroup(createResource))
                return BadRequest(BadRequestReasonExtended.NotSameVoteGroup);

            return await base.Create(createResource);
        }

        private async Task<bool> AreInSameVoteGroup(PollVoteCreateResource createResource)
        {
            return await PollGroupsApplication.AreInSameVoteGroup(
                createResource.PollId, 
                createResource.EmployeeId, 
                createResource.VotedEmployeeId);
        }
    }
}
