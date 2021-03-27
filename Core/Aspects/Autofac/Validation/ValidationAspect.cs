using System;
using System.Linq;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;

namespace Core.Aspects.Autofac.Validation
{
    //sen bir methodınterception sun.
    //madem ben oyum, benim ezmemi istediğin bir metod var mı? var : OnBefore()
    public class ValidationAspect : MethodInterception //Aspect
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            //defensive coding : savunma odaklı kodlar
            //göndermek istediğin validatorType bir IValidator mü?
            //Kafasına göre bambaşka classlar yollamasın diye.
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                //throw new System.Exception(AspectMessages.WrongValidationType);
                throw new System.Exception("Bu bir doğrulama sınıfı değil.");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            //Reflection kodu: Car car = new Created(); oluşturduğumuzu çalışma anında oluşturmak ister isek CreatedInstance() deriz.
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            //CarValidator de CarValidate nin 0. argümanı, Car tipi
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            //Sonra methodun argümanlarını gez. (CarManager Add metodu mesela).
            //Eğer oradaki tip benim tipim ile aynı ise olay tamamdır.
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
