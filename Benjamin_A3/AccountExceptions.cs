//Benjamin Lefebvre - 301234598

using System;
namespace Benjamin_A3
{
	public class InsufficientBalanceException : Exception
	{
        public override string ToString()
        {
            return "Account not having enough balance to withdraw.";
		}
    }

	public class MinimumBalanceException : Exception
	{
		public override string ToString()
		{
			return "You must maintain minimum $3000 balance in Saving account.";
		}
	}

	public class IncorrectAmountException : Exception
	{
		public override string ToString()
		{
			return "You must provide positive number for amount to be deposited.";
		}
	}

	public class OverdraftLimitException : Exception
	{
		public override string ToString()
		{
			return "Overdraft Limit exceeded. You can only use $2000 from overdraft.";
		}
	}

	public class AccountNotFoundException : Exception
	{
		public override string ToString()
		{
			return "Account with given number does not exist.";
		}
	}
}

