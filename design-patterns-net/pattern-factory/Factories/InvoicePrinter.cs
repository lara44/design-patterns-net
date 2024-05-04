using factory_method_full.Documents;
using factory_method_full.Interfaces;

namespace factory_method_full.Factories
{
    class InvoicePrinter : Printer
    {
        public override Document crearDocumento()
        {
            return new InvoiceDocument();
        }
    }
}
