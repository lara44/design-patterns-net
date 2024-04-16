
using pattern_adapter.Adapters;
using pattern_adapter.Interfaces;
using pattern_adapter.Services;

Console.WriteLine("METHODS OF PAYMENT");

// Usando el medio de pago Daviplata
IPaymentMethod daviplataMethod = new DaviplataMethod();
daviplataMethod.Pay(200000);

// Usando el medio de pago Bancolombia
IPaymentMethod bancolombiaMethod = new BancolombiaMethod();
bancolombiaMethod.Pay(200000);

// Usando el adaptador para Nequi
NequiMethod nequiMethod = new NequiMethod();
IPaymentMethod adapterNequi = new NequiAdapter(nequiMethod);
adapterNequi.Pay(250000);

Console.ReadLine();