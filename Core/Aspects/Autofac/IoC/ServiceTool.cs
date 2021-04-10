using System;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.IoC
{
    //bu yapı vasıtasıyla .netcore un kendi servislerine erişebiliriz
    public static class ServiceTool
    {
        //Serviceprovider: merkezi servis yönetimi
        public static IServiceProvider ServiceProvider { get; set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
