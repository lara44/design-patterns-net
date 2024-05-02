using abstract_factory.Factories;
using abstract_factory.Services;


var client = new Client();

Console.WriteLine("Client: Testing client code with the factory Mac");
var factoryMac = new ComponentsFactoryMac();
client.ClientMethod(factoryMac);

Console.WriteLine();

Console.WriteLine("Client: Testing client code with the factory Microsfot");
var factoryMicrosoft = new ComponentsFactoryMicrosoft();
client.ClientMethod(factoryMicrosoft);

Console.ReadLine();