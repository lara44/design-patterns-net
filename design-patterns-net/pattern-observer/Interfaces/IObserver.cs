using pattern_observer.Subjects;

namespace pattern_observer.Interfaces
{
    public interface IObserver
    {
        void Update(Invoice invoice);
    }
}
