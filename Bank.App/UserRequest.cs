using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Controllers;

namespace Bank.App
{
    internal class UserRequest
    {
        static void Main(string[] args)
        {
            string accountNum = "HDFC123";
            AccountController accountController = new AccountController();
            string userBalance = accountController.GetBalance(accountNum);
            Console.WriteLine(userBalance);
        }
    }
}
