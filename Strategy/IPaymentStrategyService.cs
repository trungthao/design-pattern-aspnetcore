using DesignPattern.FactoryMethod;

namespace DesignPattern.Strategy;

public interface IPaymentStrategyService
{
    void SetPaymentGateway(IPaymentGateway paymentGateway);

    void PaymentWithoutStrategy(string paymentName, decimal amount);
    
    void PaymentWithStrategy(decimal amount);
}