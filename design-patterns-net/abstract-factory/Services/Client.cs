using abstract_factory.Interfaces;

namespace abstract_factory.Services
{
    public class Client
    {
        public void ClientMethod(IComponentFactory factory)
        {
            var keyboards = factory.createFactoryKeyboards();
            var mouses = factory.createFactoryKMouses();

            Console.WriteLine(keyboards.loadKeyboard());
            Console.WriteLine(mouses.loadMouse());
        }
    }
}
