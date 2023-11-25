using PaymentService.Factories;

namespace PaymentService.Services;

public class PaymentService
{
    private readonly PaymentMethodFactory _paymentMethodFactory;

    public PaymentService(PaymentMethodFactory paymentMethodFactory)
    {
        _paymentMethodFactory = paymentMethodFactory;
    }

    public void ProcessPayment(PaymentMethod methodType, decimal amount)
    {
        var paymentMethod = _paymentMethodFactory.GetPaymentMethod(methodType);
        paymentMethod.ProcessPayment(amount);
    }
}
