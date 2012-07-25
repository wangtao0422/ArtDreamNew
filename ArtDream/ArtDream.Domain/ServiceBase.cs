using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using ArtDream.Model;

namespace ArtDream.Domain
{
    public class ServiceBase : IDisposable
    {
        private ArtDreamEntities _dataContext = new ArtDreamEntities();
        protected ArtDreamEntities DataContext
        {
            get { return _dataContext; }
        }

        protected bool TrySaveChanges()
        {
            try
            {
                DataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }



        #region Implementation of IDisposable

        ~ServiceBase()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;
            if (_dataContext == null) return;
            _dataContext.Dispose();
            _dataContext = null;
        }

        #endregion
    }
}
