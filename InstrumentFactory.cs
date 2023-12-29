namespace FactoryProvider
{
    public interface InstrumentFactory
    {
        public List<string> GetAvailable();
        public List<string> FindSuppliers();
    }
}
