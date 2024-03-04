using abstract_factory.Interfaces;

namespace abstract_factory.Services.Microsoft
{
    public class MouseMicrosoft : IMouse
    {
        public string loadMouse()
        {
            return "List of microsoft mouses";
        }
    }
}
