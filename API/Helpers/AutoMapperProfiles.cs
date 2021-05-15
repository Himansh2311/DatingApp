using System.Linq;
using API.DTOs;
using API.Entities;
using API.Extensions;
using AutoMapper;

namespace API.Helpers
{
    //Maps one object to another object
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()
            .ForMember(dest=>dest.PhotoURL,opt=>opt.MapFrom(src=>
            src.Photos.FirstOrDefault(x=>x.IsMain).URL))
            .ForMember(dest=>dest.Age,opt=>opt.MapFrom(src=>
            src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoDto>();
            CreateMap<MemberUpdateDto, AppUser>();
            CreateMap<RegisterDto,AppUser>();
        }
    }
}