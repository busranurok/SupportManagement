﻿using System;
using System.Linq;
using System.Reflection;
using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public AspectInterceptorSelector()
        {
        }

        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);

            //bizim için priotiy özelliğini verdiğimizde managerde sıralı gelsin
            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }

    }
}
