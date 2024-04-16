namespace pattern_adapter.Services
{
    public class NequiMethod
    {
        public void PayWithNequi(decimal value)
        {
            Console.WriteLine($"Pagando {value:C} en Nequi");
        }
    }
}
