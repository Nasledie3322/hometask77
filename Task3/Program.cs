Console.WriteLine("enter payment amount : ");
        decimal inputAmount = Convert.ToDecimal(Console.ReadLine());

        CreditCardPayment payment = new CreditCardPayment();
        payment.SetAmount(inputAmount);

        payment.Validate();

        payment.ApplyDiscount(10);
        Console.WriteLine($"Amount after 10 % discount : {payment.GetAmount():F2}");

        payment.ProcessPayment();
        payment.LogTransaction();