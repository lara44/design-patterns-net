namespace pattern_builder.Builders
{
    public class GamerComputerBuilder : ComputerBuilder
    {
        public override void BuildGraphicsCard()
        {
            this.computer.GraphicsCard = "NVIDIA GeForce RTX 3080";
        }

        public override void BuildHardDrive()
        {
            this.computer.HarkDisk = "1TB SSD";
        }

        public override void BuildProcessor()
        {
            this.computer.Processor = "Intel Core i7";
        }

        public override void BuildRAM()
        {
            this.computer.RAM = "32 GB";
        }
    }
}
