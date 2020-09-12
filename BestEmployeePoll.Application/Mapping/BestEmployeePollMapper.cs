using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Shared.Resources;
using RestApi.Application.Mapping;

namespace BestEmployeePoll.Application.Mapping
{
    public class BestEmployeePollMapper : AutoMapperProfile
    {
        public BestEmployeePollMapper()
        {
            CreateMap<PersonCreateResource, PersonEntity>();
            CreateMap<PersonResource, PersonEntity>();
            CreateMap<PersonEntity, PersonResource>().ForMember(m => m.Manager, o => o.Ignore());
        }
    }
}