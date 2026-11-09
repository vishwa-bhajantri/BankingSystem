namespace Bank.Repos
{
    public class AccountRepository : IAccountRepository
    {
        string _AccountNumber = "HDFC123";
        public string GetBalance(string AccountNumber)
        {
            if (AccountNumber == _AccountNumber)
            {
                return "You are having a balance of $1000";
            }
            else
            {
                return "You Dont Have An Account With Us";
            }
        }

        //public string Deposit(double Amount)
        //{
        //    return $"You Have Deposited ${Amount}";
        //}
    }
}
