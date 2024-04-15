using factory_method_full.Interfaces;

namespace factory_method_full.Documents
{
    public class OrderDocument : Document
    {
        public string getConfig()
        {
            return "Obtener datos configuración orden";
        }

        public string getPayload()
        {
            return "Obtener datos documento orden";
        }

        public string printDocument()
        {
            return "Imprimiendo orden...";
        }
    }
}
