using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtDream.Domain.Services.Interfaces
{
    public interface IAccountService
    {
        bool Login(string username, string password);

    }
}
