using factory_method_full.Factories;

Console.WriteLine("Factory Method!");

var orderDocument = new OrderPrinter();
Console.WriteLine(orderDocument.ImprimirDocumento());

var invoiceDocument = new InvoicePrinter();
Console.WriteLine(invoiceDocument.ImprimirDocumento());
