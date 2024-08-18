using AutoMapper;
using Library.BLL.ViewModels;
using Library.DAL.Entities;

namespace Library.BLL.AutomapperProfiles
{
    public class BookAutomapperProfile : Profile
    {
        public BookAutomapperProfile()
        {
            // BookEntity -> BookVM
            CreateMap<BookEntity, BookVM>()
                .ForMember(dest => dest.Author, opt => opt.MapFrom(src => $"{src.Author.FirstName} {src.Author.LastName}"));
        }
    }
}
