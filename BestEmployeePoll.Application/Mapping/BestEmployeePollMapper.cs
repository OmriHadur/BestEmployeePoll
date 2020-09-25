using BestEmployeePoll.Common.Entities;
using BestEmployeePoll.Shared.Resources;
using RestApi.Application.Mapping;

namespace BestEmployeePoll.Application.Mapping
{
    public class BestEmployeePollMapper : AutoMapperProfile
    {
        public BestEmployeePollMapper()
        {
            CreateMap<EmployeeCreateResource, EmployeeEntity>();
            CreateMap<EmployeeEntity, EmployeeResource>()
                .ForMember(m => m.IsManager, opt => opt.MapFrom(e => e.Staff.Count != 0));

            CreateMap<PollGroupCreateResource, PollGroupEntity>();
            CreateMap<PollGroupEntity, PollGroupResource>();

            CreateMap<PollCreateResource, PollEntity>();
            CreateMap<PollEntity, PollResource>();

            CreateMap<PollVoteCreateResource, PollVoteEntity>();
            CreateMap<PollVoteEntity, PollVoteResource>();
        }
    }
}