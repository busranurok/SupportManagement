﻿using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class TicketStatusValidator : AbstractValidator<TicketStatus>
    {
        public TicketStatusValidator()
        {
        }
    }
}
