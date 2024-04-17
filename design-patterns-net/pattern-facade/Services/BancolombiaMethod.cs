namespace pattern_adapter.Services
{
    public class BancolombiaMethod
    {
        public void PayWithBancolombia(decimal value)
        {
            Console.WriteLine($"Pagando {value:C} con interfaz Bancolombia");
        }
    }
}
