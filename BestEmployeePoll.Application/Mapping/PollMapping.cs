using AutoMapper;
using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Shared.Resources;
using Core.Server.Common;
using Core.Server.Common.Mapping;

namespace Core.Server.Application.Mapping
{
    [InjectMany]
    public class PollMapping : IResourceMapper
    {
        public void AddMapping(Profile profile)
        {
            profile.CreateMap<PollCreateResource, PollEntity>();
            profile.CreateMap<PollEntity, PollResource>();
        }
    }
}
