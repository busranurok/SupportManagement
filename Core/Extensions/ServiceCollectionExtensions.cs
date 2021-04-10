using System;
using Core.Aspects.Autofac.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Extensions
{
    //servicecollection nesnesini extension yaparız.
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection services, ICoreModule[] modules)
        {
            //bütün servisleri ekleyecek
            foreach (var module in modules)
            {
                module.Load(services);
            }

            //servicetool bizim servislerimizi yapılandırır.
            return ServiceTool.Create(services);
        }
    }
}
