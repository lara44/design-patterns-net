using pattern_state.Interfaces;

namespace pattern_state.States
{
    public class ServedOrderState : IOrderState
    {
        public void Processing()
        {
            Console.WriteLine("La orden ha sido servida al cliente.");
        }
    }
}
