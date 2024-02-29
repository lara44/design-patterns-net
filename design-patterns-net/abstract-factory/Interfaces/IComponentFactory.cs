namespace abstract_factory.Interfaces
{
    public interface IComponentFactory
    {
        public IKeyboard createFactoryKeyboards();
        public IMouse createFactoryKMouses();
    }
}
