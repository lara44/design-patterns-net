using abstract_factory.Interfaces;

namespace abstract_factory.Services.Microsoft
{
    public class KeyboardMicrosoft : IKeyboard
    {
        public string loadKeyboard()
        {
            return "List of microsoft keyboards!";
        }
    }
}
