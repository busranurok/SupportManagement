using System;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.IoC
{
    //autofacbusinessmodule deki gibi
    public interface ICoreModule
    {
        void Load(IServiceCollection services);
    }
}
