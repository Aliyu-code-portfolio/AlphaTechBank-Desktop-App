using AlphaTechBank.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTechBank.Repository.Repository.Abstraction
{
    public interface IUserRepository:IGenericRepository<User>
    {
        Task<User> GetUserById(int id);
        Task<User> GetUserByEmail(string email);
        Task<IEnumerable<User>> GetAllUsers();
        void UpdateUser(User user);
    }
}
