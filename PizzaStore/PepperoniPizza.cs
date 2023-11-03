namespace PizzaStore
{
    public class PepperoniPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing Pepperoni pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Baking Pepperoni pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting Pepperoni pizza");
        }

        public void Box()
        {
            Console.WriteLine("Boxing Pepperoni pizza");
        }
    }
}