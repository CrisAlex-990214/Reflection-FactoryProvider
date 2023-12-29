namespace FactoryProvider.Factories
{
    public class PercussionFactory : InstrumentFactory
    {
        public List<string> FindSuppliers() => new() { "Yamaha", "Mapex" };
        public List<string> GetAvailable() => new() { "Piano", "Drum" };
    }
}
