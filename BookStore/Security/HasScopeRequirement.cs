﻿using Microsoft.AspNetCore.Authorization;
using System;

namespace BookStore.Security
{
    public class HasScopeRequirement : IAuthorizationRequirement
    {
        public string Issuer { get; set; }

        public string Scope { get; set; }

        public HasScopeRequirement(string issuer, string scope)
        {
            Issuer = issuer ?? throw new ArgumentNullException(nameof(issuer));
            Scope = scope ?? throw new ArgumentNullException(nameof(scope));
        }
    }
}
