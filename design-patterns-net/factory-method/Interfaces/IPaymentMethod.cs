namespace factory_method.Interfaces
{
    public interface IPaymentMethod
    {
        public IPayment createMethodPayment(string method);
    }
}
