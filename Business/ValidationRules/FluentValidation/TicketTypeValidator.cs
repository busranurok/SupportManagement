using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class TicketTypeValidator : AbstractValidator<TicketType>
    {
        public TicketTypeValidator()
        {
        }
    }
}
