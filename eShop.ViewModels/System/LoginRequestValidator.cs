﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.ViewModels.System
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Username is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Username is required")
                .MinimumLength(6).WithMessage("Password is at least 6 characters");
        }
    }
}