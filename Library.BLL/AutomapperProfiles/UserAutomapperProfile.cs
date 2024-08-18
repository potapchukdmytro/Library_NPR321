using AutoMapper;
using Library.BLL.ViewModels;
using Library.DAL.Entities;

namespace Library.BLL.AutomapperProfiles
{
    public class UserAutomapperProfile : Profile
    {
        public UserAutomapperProfile() 
        {
            // UserEntity -> UserVM
            CreateMap<UserEntity, UserVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.ToString()))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.Name));
        }
    }
}
