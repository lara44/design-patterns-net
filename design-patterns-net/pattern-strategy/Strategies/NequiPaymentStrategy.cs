using pattern_strategy.Interfaces;

namespace pattern_strategy.Strategies
{
    public class NequiPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            // Lógica específica para realizar el pago con Nequi
            Console.WriteLine($"Pago de {amount} realizado con Nequi");
        }
    }
}
