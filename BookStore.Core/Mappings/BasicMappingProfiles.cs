using AutoMapper;
using BookStore.Models.Domain;
using BookStore.Models.DTOs;
using BookStore.Models.DTOs.Users;
using BookStore.Core.Utilities.Commands.Helpers;

namespace BookStore.Core.Mappings
{
    public class BasicMappingProfiles : Profile
    {
        public BasicMappingProfiles()
        {
            this.CreateMap<Book, BookDto>().ReverseMap();
            this.CreateMap<AuthorDto, Author>()
                .ReverseMap()
                .ForMember(x => x.FullName, y => y.MapFrom(s => $"{s.FirstName} {s.LastName}"));
            this.CreateMap<Review, ReviewDto>().ReverseMap();
            this.CreateMap<UserDto, User>().ReverseMap();
            this.CreateMap<AuthUserDto, User>()
                .ForMember(x => x.FirstName, y => y.MapFrom(z => (z.Name ?? z.Nickname).GetFirstSyllable() ?? "Unknown"))
                .ForMember(x => x.LastName, y => y.MapFrom(z => (z.Name ?? z.Nickname).GetSecondSyllable() ?? "Unknown"));
        }
    }
}
