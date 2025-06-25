using API_ITI_1.DTO.CoursesDto_s;
using API_ITI_1.Models;
using AutoMapper;

namespace API_ITI_1.Profiles
{
    public class CoursesProfile: Profile
    {
        public CoursesProfile()
        {
            CreateMap<Courses, CoursesGetDto>().
                 ForMember(x => x.Name, x => x.MapFrom(x => x.Crs_Name))
                .ForMember(x=>x.Description,x=>x.MapFrom(x=>x.Crs_Duration));
        }
    }
}
