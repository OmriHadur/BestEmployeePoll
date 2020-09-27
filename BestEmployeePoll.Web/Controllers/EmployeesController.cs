using Microsoft.AspNetCore.Mvc;
using BestEmployeePoll.Shared.Resources;
using Core.Server.Web.Controllers;
using System.Threading.Tasks;
using System.Collections.Generic;
using Core.Server.Shared.Query;

namespace BestEmployeePoll.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : RestController<EmployeeCreateResource, EmployeeResource>
    {
        public override Task<ActionResult<IEnumerable<EmployeeResource>>> Get()
        {
            return base.Get();
        }
    }
}