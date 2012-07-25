using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using System.Web.Mvc;

namespace ArtDream.Web
{
    public class UnityDependencyResolver : IDependencyResolver
    {
        private readonly IUnityContainer _mUnityContainer;

        public UnityDependencyResolver(IUnityContainer unityContainer)
        {
            this._mUnityContainer = unityContainer;
        }

        #region IDependencyResolver Members

        public object GetService(Type serviceType)
        {
            try
            {
                return this._mUnityContainer.Resolve(serviceType);
            }
            catch
            {
                /// Must be return null
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return this._mUnityContainer.ResolveAll(serviceType);
            }
            catch
            {
                /// Must be renturn empty list.
                return new List<object>();
            }
        }

        #endregion
    }
}