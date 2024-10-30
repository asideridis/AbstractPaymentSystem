using PaymentService.Strategies;

namespace PaymentService.Factories;

public class PaymentMethodFactory
{
    public IPaymentStrategy GetPaymentMethod(PaymentMethod methodType)
    {
        string className = $"{methodType}Payment";
        string namespaceName = "PaymentService.Strategies";
        
        Type paymentType = Type.GetType($"{namespaceName}.{className}");
        
        if (paymentType == null)
        {
            throw new NotImplementedException("No payment method implemented for this type.");
        }
        
        return (IPaymentStrategy)Activator.CreateInstance(paymentType);
    }
}
