using pattern_decorator.Interfaces;

namespace pattern_decorator.Decorator
{
    public class PotatoDecorator : ChickenDecorator
    {
        // Utilizar el chicken de la clase base
        public PotatoDecorator(IChicken chicken) : base(chicken)
        {

        }

        public override string GetDescription()
        {
            return $"{_chicken.GetDescription()}, con papas";
        }

        public override decimal GetPrice()
        {
            return _chicken.GetPrice() + 5500;
        }
    }
}
