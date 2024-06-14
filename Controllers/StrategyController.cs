using DesignPattern.FactoryMethod;
using DesignPattern.Strategy;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StrategyController : ControllerBase
{
    private readonly IPaymentStrategyService _paymentStrategyService;
    public StrategyController(IPaymentStrategyService paymentStrategyService)
    {
        _paymentStrategyService = paymentStrategyService;
    }
    [HttpPost]
    public IActionResult Payment(decimal amount)
    {
        IPaymentGateway paypalGateway = new PayPalGateway();
        _paymentStrategyService.SetPaymentGateway(paypalGateway);
        _paymentStrategyService.PaymentWithStrategy(amount);

        return Ok("Payment Success");
    }    
}