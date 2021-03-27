using System;
using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors
{


    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public MethodInterceptionBaseAttribute()
        {
        }

        //öncelik
        public int Priority { get; set; }

        //ne yapacağım? hangi attribute böyle çalışsın
        public virtual void Intercept(IInvocation invocation)
        {


        }
    }
}