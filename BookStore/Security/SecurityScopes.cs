using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Security
{
    public class SecurityScopes
    {
        public const string EDIT_BOOK_DETAILS = "edit:bookdetails";
        public const string CREATE_BOOK = "create:book";
        public const string CREATE_REVIEW = "create:review";
    }
}
