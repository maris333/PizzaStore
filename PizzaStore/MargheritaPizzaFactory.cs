public class MargheritaPizzaFactory : IPizzaFactory
{
    public IPizza CreatePizza()
    {
        return new MargheritaPizza();
    }
}