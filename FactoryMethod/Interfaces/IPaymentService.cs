namespace DesignPattern.FactoryMethod;

public interface IPaymentService
{
    void PaymentWithFactoryMethod(string gatewayName, decimal amount);
}