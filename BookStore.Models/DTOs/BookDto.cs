using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models.DTOs
{
    public class BookDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Rating { get; set; }
        public List<AuthorDto> Authors { get; set; }
        public List<ReviewDto> Reviews { get; set; }
    }
}
