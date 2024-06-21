namespace Bank;

class Program
{
    static void Main(string[] args)
    {
        // Write a program to create a class representing a bank. 
        // Include methods for managing customer accounts and transactions.

        var bank = new Bank();

        string acno1 = "SB-123";
        decimal damt1 = 1000;
        Console.WriteLine("New a/c No.: " + acno1 + " Deposit Amount: " + damt1);
        bank.CreateAccount(acno1, damt1);

        string acno2 = "SB-124";
        decimal damt2 = 1500;
        Console.WriteLine("New a/c No.: " + acno2 + " Deposit Amount: " + damt2);
        bank.CreateAccount(acno2, damt2);

        decimal wamt1 = 600;
        Console.WriteLine("\nDeposit Rs. " + wamt1 + " to A/c No. " + acno1);
        bank.MakeDeposit(acno1, wamt1);

        decimal wamt2 = 350;
        Console.WriteLine("Withdraw Rs. " + wamt2 + " From A/c No. " + acno2);
        bank.MakeWithdrawal(acno2, wamt2);

        Console.WriteLine("A/c. No. " + acno1);
        bank.CheckBalance(acno1);

        Console.WriteLine("A/c. No. " + acno2);
        bank.CheckBalance(acno2);

        decimal wamt3 = 1200;
        Console.WriteLine("Withdraw Rs. " + wamt3 + " From A/c No. " + acno2);
        bank.MakeWithdrawal(acno2, wamt3);

        string acno3 = "SB-134";
        Console.WriteLine("A/c. No. " + acno3);
        bank.CheckBalance(acno3);  // Non-existent account number
    }
}
