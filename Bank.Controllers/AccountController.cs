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
        IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public string GetBalance(string AccountNum)
        {
            //AccountService accountService = new AccountService();
            return _accountService.GetBalance(AccountNum);
        }
    }
}
