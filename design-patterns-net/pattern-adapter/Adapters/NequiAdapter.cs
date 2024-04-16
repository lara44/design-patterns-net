using pattern_adapter.Interfaces;
using pattern_adapter.Services;

namespace pattern_adapter.Adapters
{
    public class NequiAdapter : IPaymentMethod
    {
        private readonly NequiMethod _nequiMethod;
        public NequiAdapter(NequiMethod nequiMethod)
        {
            _nequiMethod = nequiMethod;
        }
        public void Pay(decimal value)
        {
            _nequiMethod.PayWithNequi(value);
        }
    }
}
