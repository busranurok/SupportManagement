using System;
using Castle.DynamicProxy;
using Core.Aspects.Autofac.IoC;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheRemoveAspect : MethodInterception
    {
        //cachten silinecek pattern
        string _pattern;
        ICacheManager _cacheManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }


        //yeni bir şey eklendiğinde, güncellendiğinde ve silme operasyonlarında bunu çalıştırırız.
        //mesela add oldu ama succes olmadı, bu yüzden cachenin temizlenmesi gerek.
        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(_pattern);
        }

    }
}
