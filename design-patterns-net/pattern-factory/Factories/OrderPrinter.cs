using factory_method_full.Documents;
using factory_method_full.Interfaces;

namespace factory_method_full.Factories
{
    class OrderPrinter : Printer
    {
        public override Document crearDocumento()
        {
            return new OrderDocument();
        }
    }
}
