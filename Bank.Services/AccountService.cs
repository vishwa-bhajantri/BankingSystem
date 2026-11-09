using Bank.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class AccountService : IAccountService
    {
        IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public string GetBalance(string AccountNumber)
        {
            //AccountRepository accountRepository = new AccountRepository();
            string msg = _accountRepository.GetBalance(AccountNumber);
            return msg;
        }

        //public void Deposit(double Amount)
        //{
        //    //AccountRepository accountRepository = new AccountRepository();
        //    accountRepository.Deposit(Amount);
        //}
    }
}
