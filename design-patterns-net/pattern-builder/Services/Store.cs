using pattern_builder.Builders;

namespace pattern_builder.Services
{
    public class Store
    {
        private ComputerBuilder computerBuilder;

        public void SetComputerBuilder(ComputerBuilder computerBuilder)
        {
            this.computerBuilder = computerBuilder;
        }

        public Computer ObtenerComputadora()
        {
            return this.computerBuilder.getComputer();
        }

        public void BasicComputerBuilder()
        {
            this.computerBuilder.createComputer();
            this.computerBuilder.BuildProcessor();
            this.computerBuilder.BuildRAM();
            this.computerBuilder.BuildHardDrive();
            //this.computerBuilder.BuildGraphicsCard();
        }

        public void GamerComputerBuilder()
        {
            this.computerBuilder.createComputer();
            this.computerBuilder.BuildProcessor();
            this.computerBuilder.BuildRAM();
            this.computerBuilder.BuildHardDrive();
            this.computerBuilder.BuildGraphicsCard();
        }
    }
}
