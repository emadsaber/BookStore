using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models.Domain.Base
{
    public class Entity
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
