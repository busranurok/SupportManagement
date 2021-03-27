using System;
using FluentValidation;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {

            //bir doğrulama yapacağım
            var context = new ValidationContext<object>(entity);
            //bu doğrulamayı carvalidator ü kullanarak yapacağım
            //CarValidator carValidator = new CarValidator();
            //carvalidator ü kullanarak ilgili contexti doğrula
            var result = validator.Validate(context);
            //eğer sonuç geçerli değil ise hata fırlat
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
