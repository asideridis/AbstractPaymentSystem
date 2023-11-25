namespace PaymentService.Strategies;

public abstract class PaymentMethodBase : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        PerformPreProcessing();
        ProcessPaymentCore(amount);
        PerformPostProcessing();
    }

    protected virtual void PerformPreProcessing()
    {
        // Add pre-processing logic common to all payment methods
    }

    protected abstract void ProcessPaymentCore(decimal amount);

    protected virtual void PerformPostProcessing()
    {
        // Add post-processing logic common to all payment methods
    }
}
