using pattern_strategy.Interfaces;

namespace pattern_strategy.Strategies
{
    public class DaviplataPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            // Lógica específica para realizar el pago con Daviplata
            Console.WriteLine($"Pago de {amount} realizado con Daviplata");
        }
    }
}
