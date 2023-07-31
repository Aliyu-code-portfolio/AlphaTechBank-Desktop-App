using AlphaTechBank.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTechBank.Core.Services.Abstraction
{
    public interface IAuthenticationService
    {
        Task<User> LoginUser(string email, string password);
        Task<User> RegisterUser(string email, string password);

    }
}
