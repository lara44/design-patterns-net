
using pattern_adapter.Services;
using pattern_facade.Facades;

Console.WriteLine("INTERFAZ PAGOS");

BancolombiaMethod bancolombiaMethod = new BancolombiaMethod();
DaviplataMethod daviplataMethod = new DaviplataMethod();
AvvVillasMethod avvVillasMethod = new AvvVillasMethod();

// Cliente utiliza la interfaz unificada proporcionada por el Facade
PayFacade facadePayment = new PayFacade(bancolombiaMethod, daviplataMethod, avvVillasMethod);
facadePayment.ProcessPaymentWithBancolombia(100000);
facadePayment.ProcessPaymentWithDaviplata(200000);
facadePayment.ProcessPaymentWithAvvVillas(300000);

Console.ReadLine();
