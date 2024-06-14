using DesignPattern.FactoryMethod;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FactoryMethodController : ControllerBase
{
    private readonly PaymentGatewayFactory _paymentGatewayfactory;
    private readonly IPaymentGateway _paymentGateway;
    public FactoryMethodController(PaymentGatewayFactory paymentGatewayfactory)
    {
        _paymentGatewayfactory = paymentGatewayfactory;
    }

    [HttpPost]
    public IActionResult Payment(string gatewayName, decimal amount)
    {
        var paymentGateway = _paymentGatewayfactory.CreatePaymentGateway(gatewayName);
        paymentGateway.ProcessPayment(amount);

        return Ok("Payment Success");
    }    
}