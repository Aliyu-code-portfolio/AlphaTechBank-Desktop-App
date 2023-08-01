using AlphaTechBank.Model.Model;
using AlphaTechBank.Repository.Data;
using AlphaTechBank.Repository.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTechBank.Repository.Repository.Implementation
{
    public class UserRepository :GenericRepository<User>, IUserRepository
    {
        private readonly DbSet<User> _users;

        public UserRepository(DataBaseContext databaseContext):base(databaseContext)
        {
            _users = databaseContext.Set<User>();
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _users.Where(u=>!u.IsDeleted).Include(u=>u.Accounts).ToListAsync();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _users.Where(u => u.Email == email&& !u.IsDeleted)
                .Include(u => u.Accounts).FirstOrDefaultAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _users.Where(u => u.Id == id&& !u.IsDeleted)
                .Include(u => u.Accounts).FirstOrDefaultAsync();
        }

        public void UpdateUser(User user)
        {
            _users.Update(user);
        }
    }
}
