
using pattern_observer.Observers;
using pattern_observer.Subjects;

Invoice invoice1 = new Invoice("Invoice #FV0001", 1000m);   // Create invoice1
Customer customer1 = new Customer("juan@email.com");        // Create observer1 
invoice1.RegisterObserver(customer1);                       // register observer1
invoice1.ProcessPayment();                                  // Emular proceso de pago y enviar factura electrónica
invoice1.RemoveObserver(customer1);                         // eliminar observador1

Invoice invoice2 = new Invoice("Invoice #FV0002", 2000m);   // Create invoice2
Customer customer2 = new Customer("pedro@email.com");       // Create observer2
invoice2.RegisterObserver(customer2);                       // register observer2
invoice2.ProcessPayment();                                  // Emular proceso de pago y enviar factura electrónica
invoice2.RemoveObserver(customer2);                         // eliminar observador2

Console.ReadLine();