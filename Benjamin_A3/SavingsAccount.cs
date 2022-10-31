//Benjamin Lefebvre - 301234598

using System;
namespace Benjamin_A3
{
	public class SavingsAccount : Account
	{
        public double Balance { get; set; }

		public SavingsAccount(string id, string name, int acctnumber, double balance = 0.0) :
            base (id, name, acctnumber)
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
            if (amount < this.Balance)
            {
                if ((this.Balance - amount) >= 3000)
                {
                    this.Balance -= amount;
                    Console.WriteLine($"Successfully withdrawn {amount:C} from the account number {base.AccountNum}");
                    Console.WriteLine($"Updated balance is {this.Balance:C}");
                }
                else
                {
                    Console.WriteLine(new MinimumBalanceException().ToString());
                }
            }
            else 
            {
                Console.WriteLine(new InsufficientBalanceException().ToString());
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} {"Saving",-15} {this.Balance,15:C}";
        }
    }
}

