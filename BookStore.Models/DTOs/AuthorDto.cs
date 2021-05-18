using System;

namespace BookStore.Models.DTOs
{
    public class AuthorDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName{ get; set; }
        public DateTime JoinDate { get; set; }
        public decimal Rating { get; set; }
    }
}