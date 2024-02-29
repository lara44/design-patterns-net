using abstract_factory.Interfaces;

namespace abstract_factory.Services.Microsoft
{
    internal class KeyboardMicrosoft : IKeyboard
    {
        public string loadKeyboard()
        {
            return "List of microsoft keyboards!";
        }
    }
}
