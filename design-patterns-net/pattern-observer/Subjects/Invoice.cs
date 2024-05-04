using pattern_observer.Interfaces;

namespace pattern_observer.Subjects
{
    public class Invoice : ISubject
    {
        public string Number { get; set; }
        public decimal Amount { get; set; }
        private List<IObserver> _observers;

        public Invoice(string number, decimal amount)
        {
            Number = number;
            Amount = amount;
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer); ;
        }

        public void NotifyObserver()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        // Method to simulate payment processing and invoice generation
        public void ProcessPayment()
        {
            NotifyObserver();
        }
    }
}
