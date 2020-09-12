using AutoMapper;
using BestEmployeePoll.Application.Mapping;
using Microsoft.Extensions.Configuration;
using RestApi.Web;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace BestEmployeePoll.Web
{
    public class Startup : RestApiStartup
    {
        public Startup(IConfiguration configuration)
            :base(configuration)
        {
        }

        protected override Profile GetAutoMapperProfile()
        {
            return new BestEmployeePollMapper();
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