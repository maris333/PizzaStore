using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace PizzaStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pizzaManager = new PizzaManager();
            pizzaManager.Execute();
        }
    }
}