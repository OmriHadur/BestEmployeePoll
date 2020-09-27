using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Core.Server.Web;
using Unity;
using Unity.Microsoft.DependencyInjection;

namespace BestEmployeePoll.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUnityServiceProvider(new UnityContainer())
                .UseStartup<Startup>();
    }
}
