using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Controllers;
using Bank.Repos;
using Bank.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Bank.App
{
    internal class UserRequest
    {
        static void TestMain(string[] args)
        {
            string accountNum = "HDFC123";

            IAccountRepository accountRepository = new AccountRepository();
            IAccountService accountService = new AccountService(accountRepository);


            AccountController accountController = new AccountController(accountService);
            string userBalance = accountController.GetBalance(accountNum);
            Console.WriteLine(userBalance);
        }


        static void Main(string[] args)
        {
            string accountNum = "HDFC123";

            IServiceCollection services = new ServiceCollection();

            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAccountRepository, AccountRepository>();

            IServiceProvider provider = services.BuildServiceProvider();

            IAccountService accountService = provider.GetService<IAccountService>();
            IAccountRepository accountRepository = provider.GetService<IAccountRepository>();

            AccountController accountController = new AccountController(accountService);

            string userBalance = accountController.GetBalance(accountNum);
            Console.WriteLine(userBalance);
        }
    }
}
