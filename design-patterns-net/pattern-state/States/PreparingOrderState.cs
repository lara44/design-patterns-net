using pattern_state.Interfaces;

namespace pattern_state.States
{
    public class PreparingOrderState : IOrderState
    {
        public void Processing()
        {
            Console.WriteLine("La orden está siendo preparada.");
        }
    }
}
