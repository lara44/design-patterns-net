using pattern_state.Interfaces;

namespace pattern_state.States
{
    public class ReceivedOrderState : IOrderState
    {
        public void Processing()
        {
            Console.WriteLine("La orden ha sido recibida.");
        }
    }
}
