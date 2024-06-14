namespace DesignPattern.FactoryMethod;

public class PaymentService : IPaymentService
{
    private readonly PaymentGatewayFactory _paymentGatewayFactory;
    public PaymentService(PaymentGatewayFactory paymentGatewayFactory)
    {
        _paymentGatewayFactory = paymentGatewayFactory;
    }

    public void PaymentWithFactoryMethod(string gatewayName, decimal amount)
    {
        var paymentGateway = _paymentGatewayFactory.CreatePaymentGateway(gatewayName);
        paymentGateway.ProcessPayment(amount);
    }
}