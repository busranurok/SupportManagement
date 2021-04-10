using System;
using System.Linq;
using Castle.DynamicProxy;
using Core.Aspects.Autofac.IoC;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheAspect : MethodInterception
    {
        int _duration;
        ICacheManager _cacheManager;

        //60 dk
        public CacheAspect(int duration = 60)
        {
            _duration = duration;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        //önce cache bak orada var ise cachten ekle yok ise cache ekle.
        //TicketManager.GetByUserId(1, busra) : key
        public override void Intercept(IInvocation invocation)
        {
            //ilki classın ismi, method ismini verir
            var methodName = string.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}");
            var arguments = invocation.Arguments.ToList();
            //
            var key = $"{methodName}({string.Join(separator: ",", values: arguments.Select(x=> x?.ToString()??"<Null>"))})";
            //bu key daha önce eklenmiş ise
            if (_cacheManager.IsAdd(key))
            {
                //metodu hiç çalıştırma
                invocation.ReturnValue = _cacheManager.Get(key);
                return;
            }

            //değil ise metodu çalıştır.
            invocation.Proceed();
            _cacheManager.Add(key, invocation.ReturnValue, _duration);
            base.Intercept(invocation);
        }
    }
}
