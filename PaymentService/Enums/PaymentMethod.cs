namespace PaymentService;

//Payment methods supported by the payment service
//Naming convention: <PaymentMethod>Payment
public enum PaymentMethod
{
    CreditCard,
    PayPal,
    BankTransfer
}
