using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArtDream.Domain.Services.Interfaces;
using ArtDream.Model;

namespace ArtDream.Domain.Services.Implementations
{
    public class AccountService:ServiceBase,IAccountService
    {
        public bool Login(string username, string password)
        {
            var query = from a in DataContext.Accounts
                        where a.Username == username && a.IsAdmin 
                        select a;
            var account = query.FirstOrDefault();

            return account != null;
      
        }
    }
}
