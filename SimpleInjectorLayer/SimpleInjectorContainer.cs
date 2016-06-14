using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjector
{
    public  class SimpleInjectorContainer
    {
        public static Container _container;
        public static void Initialize()
        {
            _container = new Container();
            Lifestyle _lifeStyle = Lifestyle.Transient;
           
            _container.Register(typeof(Repository.Interfaces.ILogger), typeof(Repository.Logger), (_lifeStyle));
            _container.Register(typeof(Repository.Interfaces.IPersonRepository), typeof(Repository.PersonRepository), (_lifeStyle));
            _container.Register(typeof(Repository.Interfaces.IUserRepository), typeof(Repository.UserRepository), (_lifeStyle));
            _container.Register(typeof(Repository.Interfaces.IUnitOfWork), typeof(Repository.UnitOfWork), (_lifeStyle));
            _container.Register<Repository.Context>(Lifestyle.Transient);
            _container.InterceptWith<MonitoringInterceptor>(
                       type => type.IsInterface && type.Name.EndsWith("Repository"));
            _container.Register<MonitoringInterceptor>();
            //_container.Verify();
           
        }

        public static object GetInstance<T>()
        {
           
            return _container.GetInstance(typeof(T));
           
        }

        


       
    }
   
}
