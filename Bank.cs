namespace Bank;

// Define a class called Bank to implement a simple banking system

public class Bank
{
    public Dictionary<string, decimal> Customers { get; set; } = [];
    
    public void CreateAccount(string account_number, decimal initial_balance = 0)
    {
        if (Customers.TryAdd(account_number, initial_balance))
        {
            Console.WriteLine("Account created successfully.");
        }
        else
        {
            Console.WriteLine("Account number already exists.");
        }
    }

    public void MakeDeposit(string account_number, decimal deposit_amount)
    {
        if (Customers.ContainsKey(account_number))
        {
            Customers[account_number] += deposit_amount;
            Console.WriteLine("Deposit successful.");
        }
        else
        {
            Console.WriteLine("Account does not exist.");
        }
    }

    public void MakeWithdrawal(string account_number, decimal deposit_amount)
    {
        if (Customers.TryGetValue(account_number, out decimal balance))
        {
            if (balance > deposit_amount)
            {
                Customers[account_number] -= deposit_amount;
                Console.WriteLine("Withdrawal successful.");
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }
        else
        {
            Console.WriteLine("Account does not exist.");
        }
    }

    public void CheckBalance(string account_number)
    {
        if (Customers.TryGetValue(account_number, out decimal balance))
        {
            Console.WriteLine($"Account balance: {balance}");
        }
        else
        {
            Console.WriteLine("Account does not exist.");
        }
    }
}