
using pattern_decorator.Decorator;
using pattern_decorator.Interfaces;
using pattern_decorator.Services;

Console.WriteLine("SALE OF CHICKEN");

// Pedir un pollo básico
IChicken basicCoffe = new BasicChicken();
Console.WriteLine($"Descripción: {basicCoffe.GetDescription()}");
Console.WriteLine($"Precio.....: ${basicCoffe.GetPrice()}");

// Pedir un pollo con papas
IChicken coffeWithCream = new PotatoDecorator(new BasicChicken());
Console.WriteLine($"Descripción: {coffeWithCream.GetDescription()}");
Console.WriteLine($"Precio.....: ${coffeWithCream.GetPrice()}");

// Pedir un pollo con papas y gaseosa
IChicken coffeWithCreamAndCandy = new SodaDecorator(new PotatoDecorator(new BasicChicken()));
Console.WriteLine($"Descripción: {coffeWithCreamAndCandy.GetDescription()}");
Console.WriteLine($"Precio.....: ${coffeWithCreamAndCandy.GetPrice()}");

Console.ReadLine();
