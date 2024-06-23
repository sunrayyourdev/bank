using Microsoft.EntityFrameworkCore;

namespace Bank;

public class BankContext : DbContext
{
    public DbSet<Bank> Bank { get; set; }
    public DbSet<Customer> Customer { get; set; }

    public string DbPath { get; }

    public BankContext()
    {
        DbPath = Path.Join(Environment.CurrentDirectory, "bank.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}