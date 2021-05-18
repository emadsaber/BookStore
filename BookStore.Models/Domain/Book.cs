using BookStore.Models.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models.Domain
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Rating { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
