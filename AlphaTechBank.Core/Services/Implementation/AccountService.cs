using AlphaTechBank.Core.Services.Abstraction;
using AlphaTechBank.Core.Utility;
using AlphaTechBank.Model.Enum;
using AlphaTechBank.Model.Model;
using AlphaTechBank.Repository.Repository.UnitOfWork.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTechBank.Core.Services.Implementation
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Account> CreateAccount(int userId, string firstName, string lastName, string email, int transactionPin, string phoneNumber, string accountType)
        {
            Account account = new()
            {
                UserId = userId,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                TransactionPin = transactionPin,
                PhoneNumber = phoneNumber,
                AccountType = accountType.ToLower() == "current" ? AccountType.Current : AccountType.Savings,
                MInBalance = accountType.ToLower() == "current" ? 0 : 1000,
                AccountNumber = Utilities.Generate10DigitsAccountsNumber()
            };
            await _unitOfWork.AccountRepository.CreateAsync(account);
            await _unitOfWork.SaveAsync();
            _unitOfWork.Dispose();
            return account;
        }

        public async Task DeleteAccount(string accountNumber)
        {
            Account account =await GetAccount(accountNumber);
            _unitOfWork.AccountRepository.Remove(account);
            await _unitOfWork.SaveAsync();
            _unitOfWork.Dispose();
        }

        public async Task<(bool status, string error)> Deposit(string accountNumber, decimal amount)
        {
            if (amount < 0)
            {
                return (false, "Amount cannot be less than 50 naira");
            }
            Account account = await GetAccount(accountNumber);
            account.Balance += amount;
            _unitOfWork.AccountRepository.Update(account);
            await _unitOfWork.SaveAsync();
            _unitOfWork.Dispose();
            return (true, string.Empty);
        }

        public Task<Account> GetAccountByNumber(string accountNumber)
        {
            return GetAccount(accountNumber);
        }

        public async Task<IEnumerable<Account>> GetAllAccounts()
        {
            return await _unitOfWork.AccountRepository.GetAccountUsers();
        }

        public async Task SoftDeleteAccount(string accountNumber)
        {
            Account account = await GetAccount(accountNumber);
            account.IsActive = false;
            _unitOfWork.AccountRepository.Update(account);
            await _unitOfWork.SaveAsync();
        }

        public async Task<(bool status, string error)> Transfer(string accountNumber, string creditAccountNumber, decimal amount, string description, string receiverName)
        {
            Account senderAccount = await GetAccount(accountNumber);
            Account receiverAccount = await GetAccount(creditAccountNumber);
            if (senderAccount.Balance - amount >= senderAccount.MInBalance)
            {
                senderAccount.Balance -= amount;
                receiverAccount.Balance += amount;
            }
            else
            {
                return (false, "Insufficient Balance");
            }
            Transaction senderTransaction = new()
            {
                AccountNumber = accountNumber,
                TransactionType = TransactionType.Transfer,
                Amount = amount,
                Status = Status.Success,
                Description = description,
                ReceiverAccountNumber = creditAccountNumber,
                ReceiverName = receiverName
            };
            Transaction receiverTransaction = new()
            {
                AccountNumber = creditAccountNumber,
                TransactionType = TransactionType.Transfer,
                Amount = amount,
                Status = Status.Success,
                Description = description,
            };
            _unitOfWork.AccountRepository.Update(senderAccount);
            await _unitOfWork.TransactionRepository.CreateAsync(senderTransaction);
            await _unitOfWork.TransactionRepository.CreateAsync(receiverTransaction);
            await _unitOfWork.SaveAsync();
            return (true, string.Empty);
        }

        public async Task<string> ValidateAccountNumber(string accountNumber)
        {
            return await _unitOfWork.AccountRepository.ValidateAccount(accountNumber);
        }

        public async Task<(bool status, string error)> Withdrawal(string accountNumber, decimal amount)
        {
            Account account = await GetAccount(accountNumber);
            if (account.Balance - amount >= account.MInBalance)
            {
                account.Balance -= amount;
            }
            else
            {
                return (false, "Insufficient balance");
            }
            _unitOfWork.AccountRepository.Update(account);

            //Create a transaction
            Transaction transaction = new()
            {
                AccountNumber = accountNumber,
                TransactionType = TransactionType.Withdrawal,
                Amount = amount,
                Status = Status.Success
            };
            await _unitOfWork.TransactionRepository.CreateAsync(transaction);
            await _unitOfWork.SaveAsync();
            _unitOfWork.Dispose();
            return (true, string.Empty);
        }
        private async Task<Account> GetAccount(string accountNumber)
        {
            return await _unitOfWork.AccountRepository.GetAccountByAccountNumber(accountNumber);
        }
    }
}
