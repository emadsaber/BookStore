using BookStore.Models.Domain.Base;
using System;

namespace BookStore.Models.Domain
{
    public class Review : Entity
    {
        public Guid UserId { get; set; }
        public string ReviewText { get; set; }
        public decimal Rating { get; set; }
        
        public virtual User User { get; set; }
    }
}