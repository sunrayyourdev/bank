namespace Bank;

public class Customer
{
    public int CustomerId { get; set; }
    public decimal Balance { get; set; }

    public int BankId { get; set; }
    public Bank Bank { get; set; }
}