using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ArtDream.Web
{
    public class UnityControllerActivator : IControllerActivator
    {
        #region IControllerActivator Members

        public IController Create(RequestContext requestContext, Type controllerType)
        {
            return DependencyResolver.Current.GetService(controllerType) as IController;
        }
        #endregion
    }
}