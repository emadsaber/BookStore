using BookStore.Models.Domain.Base;
using System;
using System.Collections.Generic;

namespace BookStore.Models.Domain
{
    public class User : Entity
    {
        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PasswordHash { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}