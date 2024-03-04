using pattern_builder.Services;

namespace pattern_builder.Builders
{
    public abstract class ComputerBuilder
    {
        protected Computer computer;

        public Computer getComputer()
        {
            return this.computer;
        }

        public void createComputer()
        {
            this.computer = new Computer();
        }

        public abstract void BuildProcessor();
        public abstract void BuildRAM();
        public abstract void BuildHardDrive();
        public abstract void BuildGraphicsCard();
    }
}
