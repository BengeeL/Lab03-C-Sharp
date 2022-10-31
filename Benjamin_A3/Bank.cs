//Benjamin Lefebvre - 301234598

using System;
namespace Benjamin_A3
{
	public class Bank
	{
		public static List<Account> AccountList;

		static Bank()
		{
			AccountList = new List<Account>();
			AccountList.Add(new SavingsAccount("S101", "James Finch", 222210212, 3400.90));
			AccountList.Add(new SavingsAccount("S102", "Kell Forest", 222214500, 42520.32));
			AccountList.Add(new SavingsAccount("S103", "Amy Stone", 222212000, 8273.45));
			AccountList.Add(new ChequingAccount("C104", "Kaitlin Ross", 333315002, 91230.45));
			AccountList.Add(new ChequingAccount("C105", "Adem First", 333303019, 43987.67));
			AccountList.Add(new ChequingAccount("C106", "John Doe", 333358927, 34829.76));
		}

		public static void ShowAll()
        {
			Console.WriteLine($"{new string('-', 33)} All Account Information {new string('-', 32)}");
			Console.WriteLine($"{"Consumer ID", -16} {"Name",-18} {"Account Number",-20} {"Type",-15} {"Balance",15}");
			Console.WriteLine($"{new string('-', 90)}");


			foreach (Account account in AccountList) {
				Console.WriteLine(account.ToString());
            }

			Console.WriteLine($"{new string('-', 90)}");
		}

		public static void ShowAll(int accountNum)
		{
			bool accountFound = false;

			Console.WriteLine($"{new string('-', 28)} Details of account number {accountNum} {new string('-', 28)}");

			foreach (Account account in AccountList)
			{
				if (account.AccountNum == accountNum)
                {
					if (!accountFound)
					{
						Console.WriteLine($"{"Consumer ID",-16} {"Name",-18} {"Account Number",-20} {"Type",-15} {"Balance",15}");
						Console.WriteLine($"{new string('-', 90)}");

					}

					Console.WriteLine(account.ToString());
					accountFound = true;
				}
			}

			if (!accountFound)
			{
				Console.WriteLine(new AccountNotFoundException().ToString());
			}
		}
	}
}

