using System;
using System.Diagnostics;
using Core.Aspects.Autofac.IoC;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Core.DependencyResolvers
{
    //startup da services.add dediğim merkzi olan şeyleri artık buraya ekleyebiliriz.
    public class CoreModule : ICoreModule
    {
        public CoreModule()
        {
        }

        public void Load(IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddSingleton<ICacheManager, MemoryCacheManager>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<Stopwatch>();
        }
    }
}
