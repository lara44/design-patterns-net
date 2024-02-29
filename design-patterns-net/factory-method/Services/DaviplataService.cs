using factory_method.Interfaces;

namespace factory_method.Services
{
    public class DaviplataService : IPayment
    {
        public string applyPay()
        {
            return "Daviplata processed the payment correctly!";
        }
    }
}
