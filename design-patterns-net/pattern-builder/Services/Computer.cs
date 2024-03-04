namespace pattern_builder.Services
{
    public class Computer
    {
        public string? Processor { get; set; }
        public string? RAM { get; set; }
        public string? HarkDisk { get; set; }
        public string? GraphicsCard { get; set; }

        public void Show()
        {
            Console.WriteLine($"Procesador: {Processor}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Disco Duro: {HarkDisk}");
            Console.WriteLine($"Tarjeta Gráfica: {GraphicsCard}");
        }
    }
}
