using abstract_factory.Interfaces;

namespace abstract_factory.Services.Mac
{
    public class KeyboardMac : IKeyboard
    {
        public string loadKeyboard()
        {
            return "List of mac keyboards!";
        }
    }
}
