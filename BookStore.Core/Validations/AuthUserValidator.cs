using BookStore.Models.DTOs.Users;
using FluentValidation;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Core.Validations
{
    public class AuthUserValidator : AbstractValidator<AuthUserDto>
    {
        #region ctor

        public AuthUserValidator()
        {
            this.RuleFor(x => x.AuthUserId).NotEmpty().WithMessage("Subscriber id [sub] is required");
            this.RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required");
            this.RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        }

        #endregion
    }
}
