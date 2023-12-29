using System.Reflection;

namespace FactoryProvider
{
    public class InstrumentFactoryProvider
    {
        private readonly IEnumerable<Type> factories;
        public InstrumentFactoryProvider()
        {
            factories = Assembly.GetAssembly(typeof(InstrumentFactoryProvider))
                .GetTypes().Where(x => typeof(InstrumentFactory).IsAssignableFrom(x));
        }

        public InstrumentFactory GetFactory(string name)
        {
            var factory = factories.FirstOrDefault(x => x.Name.Contains(name));
            return (InstrumentFactory)Activator.CreateInstance(factory);
        }
    }
}
