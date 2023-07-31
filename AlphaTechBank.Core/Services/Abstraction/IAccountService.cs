using AlphaTechBank.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTechBank.Core.Services.Abstraction
{
    public interface IAccountService
    {
        Task<Account> CreateAccount()
    }
}
