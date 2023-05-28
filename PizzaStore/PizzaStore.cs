namespace PizzaStore
{
    public class PizzaStore
    {
        private readonly IPizzaFactory pizzaFactory;

        public PizzaStore(IPizzaFactory pizzaFactory)
        {
            this.pizzaFactory = pizzaFactory;
        }

        public void OrderPizza()
        {
            IPizza pizza = pizzaFactory.CreatePizza();

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            Console.WriteLine("Pizza order complete!");
        }
    }
}
