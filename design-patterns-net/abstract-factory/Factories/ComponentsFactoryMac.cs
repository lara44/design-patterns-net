using abstract_factory.Interfaces;
using abstract_factory.Services.Mac;

namespace abstract_factory.Factories
{
    public class ComponentsFactoryMac : IComponentFactory
    {
        public IKeyboard createFactoryKeyboards()
        {
            return new KeyboardMac();
        }

        public IMouse createFactoryKMouses()
        {
            return new MouseMac();
        }
    }
}
