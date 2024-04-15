using pattern_decorator.Interfaces;

namespace pattern_decorator.Decorator
{
    public class SodaDecorator : ChickenDecorator
    {
        // Utilizar el chicken de la clase base
        public SodaDecorator(IChicken chicken) : base(chicken)
        {

        }

        public override string GetDescription()
        {
            return $"{_chicken.GetDescription()}, con gaseosa";
        }

        public override decimal GetPrice()
        {
            return _chicken.GetPrice() + 4000;
        }
    }
}
