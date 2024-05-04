using pattern_observer.Interfaces;
using pattern_observer.Subjects;

namespace pattern_observer.Observers
{
    // Concrete Observer
    public class Customer : IObserver
    {
        private string _email;

        public Customer(string email)
        {
            _email = email;
        }

        public void Update(Invoice invoice)
        {
            Console.WriteLine($"Enviando factura electrónica a {_email}: Factura {invoice.Number} por un total de {invoice.Amount}");
        }
    }
}
