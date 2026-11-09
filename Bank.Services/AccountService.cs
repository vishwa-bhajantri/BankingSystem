using Bank.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class AccountService
    {
        public string GetBalance(string AccountNumber)
        {
            AccountRepository accountRepository = new AccountRepository();
            string msg = accountRepository.GetBalance(AccountNumber);
            return msg;
        }
    }
}
