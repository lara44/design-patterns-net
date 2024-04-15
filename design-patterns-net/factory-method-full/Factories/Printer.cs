using factory_method_full.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace factory_method_full.Factories
{
    abstract class Printer
    {
        abstract public Document crearDocumento();

        public string ImprimirDocumento()
        {
            Document documento = crearDocumento();
            return documento.printDocument();
        }
    }
}
