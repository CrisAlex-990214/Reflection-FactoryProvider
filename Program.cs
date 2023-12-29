
using FactoryProvider;

while (true)
{
    Console.WriteLine("Type the musical instrument factory name");
    var factoryName = Console.ReadLine();

    var factory = new InstrumentFactoryProvider().GetFactory(factoryName);
    var available = factory.GetAvailable();
    Console.WriteLine("Available Instruments:");
    for (int i = 0; i < available.Count; i++) Console.WriteLine(available[i]);

    var suppliers = factory.FindSuppliers();
    Console.WriteLine("Suppliers:");
    for (int i = 0; i < suppliers.Count; i++) Console.WriteLine(suppliers[i]);
}