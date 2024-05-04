
using pattern_observer.Observers;
using pattern_observer.Subjects;

public class Program
{
    static void Main(string[] args)
    {
        Invoice invoice1 = new Invoice("Invoice #FV0001", 1000m);
        Customer customer1 = new Customer("juan@email.com");
        invoice1.RegisterObserver(customer1);
        invoice1.ProcessPayment();
        invoice1.RemoveObserver(customer1);

        Invoice invoice2 = new Invoice("Invoice #FV0002", 2000m);
        Customer customer2 = new Customer("pedro@email.com");
        invoice2.RegisterObserver(customer2);
        invoice2.ProcessPayment();
        invoice2.RemoveObserver(customer2);

        Console.ReadLine();
    }
}

