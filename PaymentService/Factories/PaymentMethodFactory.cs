using PaymentService.Strategies;

namespace PaymentService.Factories;

public class PaymentMethodFactory
{
    public IPaymentStrategy GetPaymentMethod(PaymentMethod methodType)
    {
        switch (methodType)
        {
            case PaymentMethod.CreditCard:
                return new CreditCardPayment();
            case PaymentMethod.PayPal:
                return new PayPalPayment();
            case PaymentMethod.BankTransfer:
                return new BankTransferPayment();
            // Additional payment methods
            default:
                throw new NotImplementedException("No payment method implemented for this type.");
        }
    }
}
