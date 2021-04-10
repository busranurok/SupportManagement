using System;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;

namespace Business.BusinessAspects.Autofac
{
    public class SecuredOperation : MethodInterception
    {
        public SecuredOperation()
        {
        }


        protected override void OnBefore(IInvocation invocation)
        {
            base.OnBefore(invocation);
        }
    }
}
