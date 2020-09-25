using AutoMapper;
using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Shared.Resources;
using RestApi.Common;
using RestApi.Common.Mapping;

namespace RestApi.Application.Mapping
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
