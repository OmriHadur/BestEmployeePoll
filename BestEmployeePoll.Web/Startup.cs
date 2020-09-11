using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace BestEmployeePoll.Web
{
    public class Startup : RestApi.Web.Startup
    {
        public Startup(IConfiguration configuration)
            :base(configuration)
        {
        }

        protected override IEnumerable<Assembly> GetAssemblies()
        {
            var assemblies = base.GetAssemblies().ToList();
            var dlls= Directory.GetFiles(".\\bin", "BestEmployeePoll*.dll", SearchOption.AllDirectories);
            foreach (var dll in dlls)
                assemblies.Add(Assembly.LoadFrom(dll));
            return assemblies;
        }
    }
}