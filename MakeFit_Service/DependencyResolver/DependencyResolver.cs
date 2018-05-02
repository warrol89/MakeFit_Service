using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using System.Web.Http.Dependencies;
using Unity;

namespace MakeFit_Service.DependencyResolver
{
    public class DependencyResolver : IDependencyResolver
    {
        protected IUnityContainer _container;

        public DependencyResolver(IUnityContainer container)
        {
            if(container == null)
            {
                throw new ArgumentNullException("container");
            }
            this._container = container;
        }

        public object GetService(Type serviceType)
        {
            return _container.Resolve(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceTYpe)
        {
            return _container.ResolveAll(serviceTYpe);

        }

      public IDependencyScope BeginScope()
        {
            var child = _container.CreateChildContainer();
            return new DependencyResolver(child);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public virtual void Dispose(bool disposing)
        {
            _container.Dispose();
        }
    }
}