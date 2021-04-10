using System;
using System.Diagnostics;
using Castle.DynamicProxy;
using Core.Aspects.Autofac.IoC;
using Core.Utilities.Interceptors;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.Performance
{
    public class PerformanceAspect : MethodInterception
    {
        //aralık, geçen süre
        int _interval;
        //kronometre görevi görür
        Stopwatch _stopwatch;

        public PerformanceAspect(int interval)
        {
            _interval = interval;
            _stopwatch = ServiceTool.ServiceProvider.GetService<Stopwatch>();
        }

        protected override void OnBefore(IInvocation invocation)
        {
            _stopwatch.Start();
        }


        protected override void OnAfter(IInvocation invocation)
        {
            //sn cinsinden geçen süre
            if (_stopwatch.Elapsed.TotalSeconds> _interval)
            {
                //sisteme otomatik mail attırabiliriz, log yazabilirz(yöneticiye,admine vb.)
                Debug.WriteLine(message: $"Performance : {invocation.Method.DeclaringType.FullName}.{invocation.Method.Name}-->{_stopwatch.Elapsed.TotalSeconds}");
            }
            _stopwatch.Reset();
        }
    }
}
