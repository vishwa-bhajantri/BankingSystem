using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Controllers;
using Bank.Repos;
using Bank.Services;

namespace Bank.App
{
    internal class UserRequest
    {
        static void Main(string[] args)
        {
            string accountNum = "HDFC123";

            IAccountRepository accountRepository = new AccountRepository();
            IAccountService accountService = new AccountService(accountRepository);
            

            AccountController accountController = new AccountController(accountService);
            string userBalance = accountController.GetBalance(accountNum);
            Console.WriteLine(userBalance);
        }
    }
}
