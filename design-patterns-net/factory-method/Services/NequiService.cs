using factory_method.Interfaces;

namespace factory_method.Services
{
    public class NequiService : IPayment
    {
        public string applyPay()
        {
            return "Nequi processed the payment correctly!";
        }
    }
}
