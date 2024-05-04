
using pattern_strategy.Strategies;

// Estrategia de pago con Daviplata
var daviplataStrategy = new DaviplataPaymentStrategy();
var daviplataPaymentContext = new PaymentContext(daviplataStrategy);
daviplataPaymentContext.ExecutePayment(100);

// Estrategia de pago con Nequi
var nequiStrategy = new NequiPaymentStrategy();
var nequiPaymentContext = new PaymentContext(nequiStrategy);
nequiPaymentContext.ExecutePayment(200);

// Estrategia de pago con Bancolombia
var bancolombiaStrategy = new BancolombiaPaymentStrategy();
var bancolombiaPaymentContext = new PaymentContext(bancolombiaStrategy);
bancolombiaPaymentContext.ExecutePayment(300);

Console.ReadLine();


