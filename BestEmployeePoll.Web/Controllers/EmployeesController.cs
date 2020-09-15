using Microsoft.AspNetCore.Mvc;
using BestEmployeePoll.Shared.Resources;
using RestApi.Web.Controllers;

namespace BestEmployeePoll.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : RestController<EmployeeCreateResource, EmployeeResource>
    {

    }
}