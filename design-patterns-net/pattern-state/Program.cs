
using pattern_state.Services;
using pattern_state.States;

public class Program
{
    private static void Main(string[] args)
    {
        Order order = new Order();

        order.ProcessingOrder(); // Output: El pedido ha sido recibido.

        order.SetState(new PreparingOrderState());
        order.ProcessingOrder(); // Output: El pedido está siendo preparado.

        order.SetState(new ServedOrderState());
        order.ProcessingOrder(); // Output: El pedido ha sido servido al cliente.

        Console.ReadLine();
    }
}