using Microsoft.Extensions.Configuration;
using Core.Server.Web;

namespace BestEmployeePoll.Web
{
    public class Startup : CoreServerStartup
    {
        public Startup(IConfiguration configuration)
            :base(configuration)
        {
        }
    }
}