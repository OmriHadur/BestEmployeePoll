using AutoMapper;
using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Shared.Resources;
using Core.Server.Common;
using Core.Server.Common.Mapping;

namespace Core.Server.Application.Mapping
{
    [InjectMany]
    public class EmployeeMapping : IResourceMapper
    {
        public void AddMapping(Profile profile)
        {
            profile.CreateMap<EmployeeCreateResource, EmployeeEntity>();
            profile.CreateMap<EmployeeEntity, EmployeeResource>();
        }
    }
}
