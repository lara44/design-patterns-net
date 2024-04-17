using pattern_adapter.Services;

namespace pattern_facade.Facades
{
    public class PayFacade
    {
        private readonly BancolombiaMethod _bancolombiaMethod;
        private readonly DaviplataMethod _daviplataMethod;
        private readonly AvvVillasMethod _avvillasMethod;

        public PayFacade(BancolombiaMethod bancolombiaMethod, DaviplataMethod daviplataMethod, AvvVillasMethod avvillasMethod)
        {
            _bancolombiaMethod = bancolombiaMethod;
            _daviplataMethod = daviplataMethod;
            _avvillasMethod = avvillasMethod;
        }

        public void ProcessPaymentWithBancolombia(decimal value)
        {
            _bancolombiaMethod.PayWithBancolombia(value);
        }

        public void ProcessPaymentWithDaviplata(decimal value)
        {
            _daviplataMethod.PayWithDaviplata(value);
        }

        public void ProcessPaymentWithAvvVillas(decimal value)
        {
            _avvillasMethod.PayWithAvvVillas(value);
        }
    }
}
