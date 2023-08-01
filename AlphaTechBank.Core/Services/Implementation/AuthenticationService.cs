using AlphaTechBank.Core.Services.Abstraction;
using AlphaTechBank.Core.Utility;
using AlphaTechBank.Model.Model;
using AlphaTechBank.Repository.Repository.UnitOfWork.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTechBank.Core.Services.Implementation
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AuthenticationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<(User user, string error)> LoginUser(string email, string password)
        {
            if (email.IsEmailValid())
            {
                User user = await _unitOfWork.UserRepository.GetUserByEmail(email);
                if (user is null || !password.CompareHash(user.PasswordSalt, user.Password))
                {
                    return (user, "Email or Password is incorrect");
                }
                return (user, string.Empty);
            }
            return (new User(), "Invalid email address");
        }

        public async Task<(bool status, string error)> RegisterUser(string email, string password)
        {
            if (email.IsEmailValid())
            {
                var passwordDetails = password.GenerateHash();
                User user = new User() { Email = email, Password = passwordDetails[0], PasswordSalt = passwordDetails[1] };
                _unitOfWork.UserRepository.CreateAsync(user);
                await _unitOfWork.SaveAsync();
                _unitOfWork.Dispose();
                return (true, string.Empty);
            }
            else
            {
                return (false, "Invalid email format");
            }

        }
    }
}
