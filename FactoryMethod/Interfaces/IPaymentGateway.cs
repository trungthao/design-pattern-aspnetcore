namespace DesignPattern.FactoryMethod;

public interface IPaymentGateway
{
    void ProcessPayment(decimal amount);
}