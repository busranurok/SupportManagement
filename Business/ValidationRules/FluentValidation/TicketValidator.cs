using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class TicketValidator: AbstractValidator<Ticket>
    {
        public TicketValidator()
        {
            RuleFor(expression: t => t.Body).Length(50,500);
        }

    }
}
