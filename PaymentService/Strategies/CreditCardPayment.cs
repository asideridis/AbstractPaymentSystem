namespace PaymentService.Strategies;

public class CreditCardPayment :PaymentMethodBase
{
    protected override void ProcessPaymentCore(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment for {amount}");
    }
}
