using pattern_strategy.Interfaces;

namespace pattern_strategy.Strategies
{
    public class BancolombiaPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            // Lógica específica para realizar el pago con Bancolombia
            Console.WriteLine($"Pago de {amount} realizado con Bancolombia");
        }
    }
}
