namespace PaymentService.Strategies;

public class PayPalPayment : PaymentMethodBase
{
    protected override void ProcessPaymentCore(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment for {amount}");
    }
}
