using Microsoft.Extensions.Configuration;
using RestApi.Web;

namespace BestEmployeePoll.Web
{
    public class Startup : RestApiStartup
    {
        public Startup(IConfiguration configuration)
            :base(configuration)
        {
        }
    }
}