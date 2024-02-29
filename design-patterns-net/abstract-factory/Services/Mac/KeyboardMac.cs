using abstract_factory.Interfaces;

namespace abstract_factory.Services.Mac
{
    internal class KeyboardMac : IKeyboard
    {
        public string loadKeyboard()
        {
            return "List of mac keyboards!";
        }
    }
}
