namespace FactoryProvider.Factories
{
    public class StringFactory : InstrumentFactory
    {
        public List<string> FindSuppliers() => new() { "Gibson", "Cecilio" };

        public List<string> GetAvailable() => new() { "Guitar", "Violin" };
    }
}
