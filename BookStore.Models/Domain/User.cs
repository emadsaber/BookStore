using BookStore.Models.Domain.Base;
using System;
using System.Collections.Generic;

namespace BookStore.Models.Domain
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AuthUserId { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public bool EmailVerified { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}