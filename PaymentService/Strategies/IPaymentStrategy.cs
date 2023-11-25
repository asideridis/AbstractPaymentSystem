namespace PaymentService.Strategies;

public interface IPaymentStrategy
{
    void ProcessPayment(decimal amount);
}
