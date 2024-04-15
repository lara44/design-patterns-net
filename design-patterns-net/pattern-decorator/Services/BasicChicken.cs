using pattern_decorator.Interfaces;

namespace pattern_decorator.Services
{
    public class BasicChicken : IChicken
    {
        public string GetDescription()
        {
            return "Basic Chicken";
        }

        public decimal GetPrice()
        {
            return 10000;
        }
    }
}
