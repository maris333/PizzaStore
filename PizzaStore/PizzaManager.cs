using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace PizzaStore
{
    internal class PizzaManager
    {
        public void Execute()
        {
            var container = CreateContainer();
            RegisterPizza(container);
            GetUserInputAndRegisterPizzaFactory(container);
            RegisterPizzaStore(container);
            Verify(container);
            Resolve(container);
        }

        private Container CreateContainer()
        {
            return new Container();
        }

        private void RegisterPizza(Container container)
        {
            container.Collection.Register<IPizza>(typeof(MargheritaPizza), typeof(PepperoniPizza));
        }

        private void RegisterMargheritaPizzaFactory(Container container)
        {
            container.Register<IPizzaFactory, MargheritaPizzaFactory>();
        }

        private void RegisterPepperoniPizzaFactory(Container container)
        {
            container.Register<IPizzaFactory, PepperoniPizzaFactory>();
        }

        private void RegisterPizzaStore(Container container)
        {
            container.Register<PizzaStore>();
        }

        private void Verify(Container container)
        {
            container.Verify();
        }

        private void Resolve(Container container)
        {
            using (AsyncScopedLifestyle.BeginScope(container))
            {
                var pizzaStore = container.GetInstance<PizzaStore>();
                pizzaStore.OrderPizza();
            }
        }

        private void GetUserInputAndRegisterPizzaFactory(Container container)
        {
            Console.WriteLine("Choose margherita or pepperoni pizza:");
            var input = Console.ReadLine();

            switch (input)
            {
                case "margherita":
                    RegisterMargheritaPizzaFactory(container);
                    break;
                case "pepperoni":
                    RegisterPepperoniPizzaFactory(container);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
