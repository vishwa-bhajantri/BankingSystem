using Bank.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Controllers
{
    public class AccountController
    {
        IAccountService accountService;
        public AccountController()
        {
            accountService = new AccountService();
        }
        public string GetBalance(string AccountNum)
        {
            //AccountService accountService = new AccountService();
            return accountService.GetBalance(AccountNum);

        }
    }
}
