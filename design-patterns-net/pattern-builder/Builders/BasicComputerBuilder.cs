namespace pattern_builder.Builders
{
    public class BasicComputerBuilder : ComputerBuilder
    {
        public override void BuildGraphicsCard()
        {
            //this.computer.Processor = "Integrada";
        }

        public override void BuildHardDrive()
        {
            this.computer.HarkDisk = "500GB HDD";
        }

        public override void BuildProcessor()
        {
            this.computer.Processor = "4GB DDR3";
        }

        public override void BuildRAM()
        {
            this.computer.RAM = "8GB";
        }
    }
}
