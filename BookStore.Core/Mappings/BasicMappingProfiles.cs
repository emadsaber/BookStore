using AutoMapper;
using BookStore.Models.Domain;
using BookStore.Models.DTOs;

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
            this.CreateMap<UserDto, User>()
                .ReverseMap()
                .ForMember(x => x.FullName, y => y.MapFrom( z => $"{z.FirstName} {z.LastName}"))
                .ForMember(x => x.FullNameWithTitle, y => y.MapFrom( z => $"{z.Title} {z.FirstName} {z.LastName}"));
        }
    }
}
