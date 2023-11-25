using PaymentService;
using PaymentService.Factories;

class Program
{
    static void Main(string[] args)
    {
        var paymentMethodFactory = new PaymentMethodFactory();
        var paymentService = new PaymentService.Services.PaymentService(paymentMethodFactory);

        // Example
        paymentService.ProcessPayment(PaymentMethod.CreditCard, 100.00m);
    }
}