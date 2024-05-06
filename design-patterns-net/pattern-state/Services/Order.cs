using pattern_state.Interfaces;
using pattern_state.States;

namespace pattern_state.Services
{
    public class Order
    {
        private IOrderState _state;

        public Order()
        {
            _state = new ReceivedOrderState();
        }

        public void SetState(IOrderState state)
        {
            _state = state;
        }

        public void ProcessingOrder()
        {
            _state.Processing();
        }
    }
}
