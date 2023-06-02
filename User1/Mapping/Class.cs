using AutoMapper;
using User1.Dtos;
using User1.Model;

namespace User1.Mapping
{
    public class GeneralProfile:Profile
    {
        public GeneralProfile() {
            CreateMap<RegisterRequestDto, UserLogin>()
            .ForMember(dest =>
            dest.PasswordHash,
            opt => opt.MapFrom(src => src.Password))
            .ForMember(dest =>
            dest.PasswordSalt,
            opt => opt.MapFrom(src => src.Password));


            CreateMap<UserLogin, GetUserDto>();

        }
    }
}
