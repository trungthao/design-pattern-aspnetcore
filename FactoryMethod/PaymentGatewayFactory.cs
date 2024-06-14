namespace DesignPattern.FactoryMethod;

//Factory Class to Produce the Products
public class PaymentGatewayFactory
{
    public IPaymentGateway CreatePaymentGateway(string gatewayName)
    {
        switch (gatewayName.ToLower())
        {
            case "paypal":
                return new PayPalGateway();
            case "stripe":
                return new StripeGateway();
            case "creditcard":
                return new CreditCardGateway();
            default:
                throw new ArgumentException("Invalid payment gateway specified");
        }
    }
}