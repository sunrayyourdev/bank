namespace Bank;

class Program
{
    static void Main(string[] args)
    {

        var db = new BankContext();

        // Note: This sample requires the database to be created before running.
        Console.WriteLine($"Database path: {db.DbPath}.");

        // Create
        db.Add(new Bank() { Name = "ABC Bank"});
        db.SaveChanges();

        // Read
        Console.WriteLine("Querying for a bank");
        var bank = db.Banks
            .OrderBy(b => b.BankId)
            .First();
        Console.WriteLine($"Bank Id: {bank.BankId} Name: {bank.Name}");

        // Update
        Console.WriteLine("Updating the blog and adding a post");
        bank.Name = "ABCD Bank";
        bank.Customers.Add(
            new Customer { Balance = 1000});
        Console.WriteLine($"Bank Id: {bank.BankId} Name: {bank.Name}");
        db.SaveChanges();

        // // Delete
        // Console.WriteLine("Delete the blog");
        // db.Remove(blog);
        // db.SaveChanges();
    }
}
