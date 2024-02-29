using abstract_factory.Interfaces;
using abstract_factory.Services.Microsoft;

namespace abstract_factory.Factories
{
    public class ComponentsFactoryMicrosoft : IComponentFactory
    {
        public IKeyboard createFactoryKeyboards()
        {
            return new KeyboardMicrosoft();
        }

        public IMouse createFactoryKMouses()
        {
            return new MouseMicrosoft();
        }
    }
}
