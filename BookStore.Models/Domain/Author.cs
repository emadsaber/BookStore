using BookStore.Models.Domain.Base;
using System;
using System.Collections.Generic;

namespace BookStore.Models.Domain
{
    public class Author : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal Rating { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}