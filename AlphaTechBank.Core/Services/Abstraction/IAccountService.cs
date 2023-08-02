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
        Task<Account> CreateAccount(int userId, string firstName, string lastName, string email, int transactionPin, string PhoneNumber, string AccountType);
        Task DeleteAccount(string accountNumber);
        Task SoftDeleteAccount(string accountNumber);
        Task<Account> GetAccountByNumber(string accountNumber);
        Task<IEnumerable<Account>> GetAllUserAccounts(int userId);
        Task<IEnumerable<Account>> GetAllAccounts();
        Task<string> ValidateAccountNumber(string accountNumber);
        Task<(bool status, string error)> Deposit(string accountNumber, decimal amount);
        Task<(bool status, string error)> Withdrawal(string accountNumber, decimal amount);
        Task<(bool status, string error)> Transfer(string accountNumber, string creditAccountNumber, decimal amount, string description, string receiverName);
    }
}
