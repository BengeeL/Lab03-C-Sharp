//Benjamin Lefebvre - 301234598

using System;
namespace Benjamin_A3
{
	public class ChequingAccount : Account
	{
        public double Balance { get; set; }

        public ChequingAccount(string id, string name, int acctnumber, double balance = 0.0) :
            base(id, name, acctnumber)
        {
            this.Balance = balance;
        }

        public override void Deposit(double amount)
        {
            if (amount >= 0)
            {
                this.Balance += amount;
                Console.WriteLine($"Successfully deposited {amount:C} to the account number {base.AccountNum}");
                Console.WriteLine($"Updated balance is {this.Balance:C}");
            }
            else
            {
                Console.WriteLine(new IncorrectAmountException().ToString());
            }
        }

        public override void Withdraw(double amount)
        {
            const int OVERDRAFT = 2000;

            if (amount < (this.Balance + OVERDRAFT))
            {
                this.Balance -= amount;
                Console.WriteLine($"Successfully withdrawn {amount:C} from the account number {base.AccountNum}");
                Console.WriteLine($"Updated balance is {this.Balance:C}");
            }
            else
            {
                Console.WriteLine(new OverdraftLimitException().ToString());
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} {"Chequing",-15} {this.Balance,15:C}";
        }
    }
}

