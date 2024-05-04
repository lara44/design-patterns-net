using pattern_strategy.Interfaces;

namespace pattern_strategy.Strategies
{
    public class PaymentContext
    {
        private IPaymentStrategy _paymentStrategy;

        public PaymentContext(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ExecutePayment(double amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }
}
