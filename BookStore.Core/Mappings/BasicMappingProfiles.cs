using AutoMapper;
using BookStore.Models.Domain;
using BookStore.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.Mappings
{
    public class BasicMappingProfiles : Profile
    {
        public BasicMappingProfiles()
        {
            this.CreateMap<Book, BookDto>().ReverseMap();
        }
    }
}
