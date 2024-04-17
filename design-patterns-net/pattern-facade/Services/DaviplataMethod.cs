namespace pattern_adapter.Services
{
    public class DaviplataMethod
    {
        public void PayWithDaviplata(decimal value)
        {
            Console.WriteLine($"Pagando {value:C} con interfaz daviplata");
        }
    }
}
