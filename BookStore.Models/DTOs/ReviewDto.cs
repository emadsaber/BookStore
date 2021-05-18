using System;

namespace BookStore.Models.DTOs
{
    public class ReviewDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string ReviewText { get; set; }
        public decimal Rating { get; set; }
        
        public UserDto User { get; set; }
    }
}