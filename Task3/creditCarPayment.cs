class CreditCardPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine($"Processing credit card payment of {Amount:F2}");
    }
}