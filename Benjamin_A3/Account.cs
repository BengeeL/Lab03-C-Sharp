//Benjamin Lefebvre - 301234598

using System;
namespace Benjamin_A3
{
	public abstract class Account : Consumer
	{
		public int AccountNum { get; }

		public Account(string id, string name, int acctnumber) :
			base (id, name)
		{
			this.AccountNum = acctnumber;
		}

		public abstract void Withdraw(double amount);
		public abstract void Deposit(double amount);

		public override string ToString()
        {
			return $"{base.ToString()} {this.AccountNum,-20}";
		}
    }
}

