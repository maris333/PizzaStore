using SimpleInjector;
using SimpleInjector.Lifestyles;

public class Program
{
    public static void Main(string[] args)
    {
        // Create container instance
        var container = new Container();

        // Register dependencies
        container.Register<IPizza, MargheritaPizza>();

        container.Collection.Register<IPizza>(typeof(MargheritaPizza), typeof(PepperoniPizza));

        Console.WriteLine("Choose margherita or pepperoni pizza:");
        var input = Console.ReadLine();

        if(input == "margherita")
        {
            container.Register<IPizzaFactory, MargheritaPizzaFactory>();
        }
        else if(input == "pepperoni")
        {
            container.Register<IPizzaFactory, PepperoniPizzaFactory>();
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            Environment.Exit(0);
        }
        
        container.Register<PizzaStore>();

        // Verify container configuration
        container.Verify();

        // Resolve and use PizzaStore
        using (AsyncScopedLifestyle.BeginScope(container))
        {
            var pizzaStore = container.GetInstance<PizzaStore>();
            pizzaStore.OrderPizza();
        }
    }
}