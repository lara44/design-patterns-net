using pattern_decorator.Interfaces;

namespace pattern_decorator.Decorator
{
    public abstract class ChickenDecorator : IChicken
    {
        protected IChicken _chicken;

        public ChickenDecorator(IChicken chicken)
        {
            _chicken = chicken;
        }

        public virtual string GetDescription()
        {
            return _chicken.GetDescription();
        }

        public virtual decimal GetPrice()
        {
            return _chicken.GetPrice();
        }
    }
}
