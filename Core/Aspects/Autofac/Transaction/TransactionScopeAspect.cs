using System;
using System.Transactions;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;

namespace Core.Aspects.Autofac.Transaction
{
    public class TransactionScopeAspect : MethodInterception
    {
        public TransactionScopeAspect()
        {
        }

        public override void Intercept(IInvocation invocation)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    invocation.Proceed();
                    transactionScope.Complete();
                }
                catch (Exception ex)
                {
                    //başarılı olamadı ise yapılan işlemleri geri alıp hata frılatırız.
                    transactionScope.Dispose();
                    throw ex;
                }

            }
        }
    }
}
