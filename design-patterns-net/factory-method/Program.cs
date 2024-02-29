using factory_method.Factories;

var paymentMethodCreator = new PaymentMethodCreator();

var methodNequi = paymentMethodCreator.createMethodPayment("Nequi");
Console.WriteLine(methodNequi.applyPay());

var methodDaviplata = paymentMethodCreator.createMethodPayment("Daviplata");
Console.WriteLine(methodDaviplata.applyPay());

