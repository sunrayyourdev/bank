using Microsoft.EntityFrameworkCore;

namespace Bank;

public class BankContext : DbContext
{
    public DbSet<Bank> Banks { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public string DbPath { get; }

    public BankContext()
    {
        DbPath = Path.Join(Environment.CurrentDirectory, "bank.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}