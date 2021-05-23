using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models.DTOs
{
    public class BookDto
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public decimal Rating { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string Website { get; set; }
        public int PagesCount { get; set; }
        public List<AuthorDto> Authors { get; set; }
        public List<ReviewDto> Reviews { get; set; }
    }
}
