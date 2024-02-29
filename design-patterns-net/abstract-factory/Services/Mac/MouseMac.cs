using abstract_factory.Interfaces;

namespace abstract_factory.Services.Mac
{
    public class MouseMac : IMouse
    {
        public string loadMouse()
        {
            return "List of mac mouses!";
        }
    }
}
