namespace PizzaStore
{
    public class PepperoniPizzaFactory : IPizzaFactory
    {
        public IPizza CreatePizza()
        {
            return new PepperoniPizza();
        }
    }
}