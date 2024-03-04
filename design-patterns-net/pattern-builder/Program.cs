// See https://aka.ms/new-console-template for more information
using pattern_builder.Builders;
using pattern_builder.Services;

Console.WriteLine("Hello, World!");

Store store = new Store();
ComputerBuilder BasicComputerBuilder = new BasicComputerBuilder();
ComputerBuilder GamerComputerBuilder = new GamerComputerBuilder();

store.SetComputerBuilder(BasicComputerBuilder);
store.BasicComputerBuilder();
Computer computer = store.ObtenerComputadora();
Console.WriteLine("Computadora Básica:");
computer.Show();

store.SetComputerBuilder(GamerComputerBuilder);
store.GamerComputerBuilder();
computer = store.ObtenerComputadora();
Console.WriteLine("\nComputadora Gamer:");
computer.Show();
