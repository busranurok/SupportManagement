using System;
using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        //cross cutting concerns
        //aop: aspect oriented programing
        public UserValidator()
        {
            RuleFor(expression: u=> u.Email).NotEmpty();
            RuleFor(expression: u=> u.LastName).Length(2,30);
        }
    }
}
