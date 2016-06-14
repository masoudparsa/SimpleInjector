using Castle.DynamicProxy;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjector
{
    public class MonitoringInterceptor : IInterceptor
    {
        private readonly ILogger logger;

        public MonitoringInterceptor(ILogger logger)
        {
            this.logger = logger;
        }

        public void Intercept(IInvocation invocation)
        {
            

            MethodBase method = invocation.GetConcreteMethod();
            // Calls the decorated instance.
            invocation.Proceed();

            var decoratedType = invocation.InvocationTarget.GetType();
           
            this.logger.Log(string.Format("Method {0} excuted in {1}",method.Name,DateTime.Now.ToString()));
        }
    }
}
