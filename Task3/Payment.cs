public abstract class Payment
{
    public decimal Amount { get; set; }

    public void SetAmount(decimal amount)
    {
        Amount = amount;
    }

    public decimal GetAmount()
    {
        return Amount;
    }

    public void Validate()
    {
        if (Amount > 0)
            Console.WriteLine("Valid amount.");
        else
            Console.WriteLine("Invalid amount.");
    }

    public void ApplyDiscount(decimal percent)
    {
        Amount = Amount - (Amount * percent / 100);
    }

    public abstract void ProcessPayment();

    public void LogTransaction()
    {
        Console.WriteLine("Transaction logged");
    }
}