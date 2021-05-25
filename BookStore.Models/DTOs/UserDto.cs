using System;

namespace BookStore.Models.DTOs
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string FullNameWithTitle { get; set; }
        public string FullName { get; set; }
    }
}