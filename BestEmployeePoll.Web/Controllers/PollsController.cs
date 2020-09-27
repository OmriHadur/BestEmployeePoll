using Microsoft.AspNetCore.Mvc;
using BestEmployeePoll.Shared.Resources;
using Core.Server.Web.Controllers;

namespace BestEmployeePoll.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PollsController : RestController<PollCreateResource, PollResource>
    {
    }
}