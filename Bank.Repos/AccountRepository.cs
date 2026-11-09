using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repos
{
    public class AccountRepository
    {
        string _AccountNumber = "HDFC123";
        public string GetBalance(string AccountNumber)
        {
            if(AccountNumber == _AccountNumber)
            {
                return "You are having a balance of $1000";
            }
            else
            {
                return "You Dont Have An Account With Us";
            }
        }
    }
}
