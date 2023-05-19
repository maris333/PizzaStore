public class MargheritaPizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Margherita pizza");
    }

    public void Bake()
    {
        Console.WriteLine("Baking Margherita pizza");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting Margherita pizza");
    }

    public void Box()
    {
        Console.WriteLine("Boxing Margherita pizza");
    }
}