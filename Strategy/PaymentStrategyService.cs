using DesignPattern.FactoryMethod;

namespace DesignPattern.Strategy;

public class PaymentStrategyService : IPaymentStrategyService
{
    private IPaymentGateway? _paymentGateway;

    // Method với nhiều loại đối tượng cùng thực hiện 1 kiểu nhiệm vụ nào đó
    // trong ví dụ này cùng là hành động thanh toán nhưng qua nhiều cổng thanh toán khác nhau
    public void PaymentWithoutStrategy(string gatewayName, decimal amount)
    {
        switch (gatewayName.ToLower())
        {
            case "paypal":
                new PayPalGateway().ProcessPayment(amount);
                break;
            case "stripe":
                new StripeGateway().ProcessPayment(amount);
                break;
            case "creditcard":
                new CreditCardGateway().ProcessPayment(amount);
                break;
            default:
                throw new ArgumentException("Invalid payment gateway specified");
        }
        
        // other business here
    }

    public void PaymentWithStrategy(decimal amount)
    {
        if (_paymentGateway != null)
            _paymentGateway.ProcessPayment(amount);
    }

    public void SetPaymentGateway(IPaymentGateway paymentGateway)
    {
        _paymentGateway = paymentGateway;
    }
}