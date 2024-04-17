namespace pattern_adapter.Services
{
    public class AvvVillasMethod
    {
        public void PayWithAvvVillas(decimal value)
        {
            Console.WriteLine($"Pagando {value:C} con interfaz AvvVillas");
        }
    }
}
