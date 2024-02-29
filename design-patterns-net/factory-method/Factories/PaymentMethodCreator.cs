using factory_method.Interfaces;
using factory_method.Services;

namespace factory_method.Factories
{
    public class PaymentMethodCreator : IPaymentMethod
    {
        public IPayment createMethodPayment(string method)
        {
            switch (method)
            {
                case "Nequi":
                    return new NequiService();

                case "Daviplata":
                    return new DaviplataService();

                default:
                    throw new ArgumentException($"Payment Method: {method} is not supported.");
            }
        }
    }
}
