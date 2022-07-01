using AutoMapper;
using Domain;

namespace Aplication.Activities.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Activity, Activity>();
        }
    }
}