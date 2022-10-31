//Benjamin Lefebvre - 301234598

using Benjamin_A3;

TestAccounts();

static void TestAccounts()
{
    Console.WriteLine($"{new string('-', 34)} Banking Application {new string('-', 34)}\n");

    Bank.AccountList.Add(new SavingsAccount("S647", "Alex Du", 222290192, 4783.98));
    Bank.AccountList.Add(new ChequingAccount("C576", "Dale Stayne", 333312312, 12894.56));

    Bank.ShowAll();

    Console.WriteLine($"{new string('-', 90)}");
    Console.WriteLine("Trying to withdraw $500.00 from the following account");
    Console.WriteLine(Bank.AccountList[0].ToString());
    Bank.AccountList[0].Withdraw(500.00);
    Console.WriteLine($"{new string('-', 90)}");

    Console.WriteLine($"{new string('-', 90)}");
    Console.WriteLine("Trying to deposit $-250.00 to the following account");
    Console.WriteLine(Bank.AccountList[1].ToString());
    Bank.AccountList[1].Deposit(-250.00);
    Console.WriteLine($"{new string('-', 90)}");

    Console.WriteLine($"{new string('-', 90)}");
    Console.WriteLine("Trying to withdraw $10000.00 to the following account");
    Console.WriteLine(Bank.AccountList[2].ToString());
    Bank.AccountList[2].Withdraw(10000.00);
    Console.WriteLine($"{new string('-', 90)}");

    Console.WriteLine($"{new string('-', 90)}");
    Console.WriteLine("Trying to deposit $5000.00 to the following account");
    Console.WriteLine(Bank.AccountList[2].ToString());
    Bank.AccountList[2].Deposit(5000.00);
    Console.WriteLine($"{new string('-', 90)}");

    Console.WriteLine($"{new string('-', 90)}");
    Console.WriteLine("Trying to deposit $7300.00 to the following account");
    Console.WriteLine(Bank.AccountList[3].ToString());
    Bank.AccountList[3].Deposit(7300.90);
    Console.WriteLine($"{new string('-', 90)}");

    Console.WriteLine($"{new string('-', 90)}");
    Console.WriteLine("Trying to withdraw $45000.40 from the following account");
    Console.WriteLine(Bank.AccountList[4].ToString());
    Bank.AccountList[4].Withdraw(45000.40);
    Console.WriteLine($"{new string('-', 90)}");

    Console.WriteLine($"{new string('-', 90)}");
    Console.WriteLine("Trying to withdraw $37000.00 from the following account");
    Console.WriteLine(Bank.AccountList[5].ToString());
    Bank.AccountList[5].Withdraw(37000);
    Console.WriteLine($"{new string('-', 90)}");

    Console.WriteLine($"{new string('-', 90)}");
    Bank.ShowAll(67676767);
    Console.WriteLine($"{new string('-', 90)}");

    Bank.ShowAll();
}