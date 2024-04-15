using factory_method_full.Interfaces;

namespace factory_method_full.Documents
{
    public class InvoiceDocument : Document
    {
        public string getConfig()
        {
            return "Obtener datos configuración factura";
        }

        public string getPayload()
        {
            return "Obtener datos documento factura";
        }

        public string printDocument()
        {
            return "Imprimiendo factura...";
        }
    }
}
