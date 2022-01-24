using LSP.Interfaces;
namespace LSP.Animals;
public class Lion : IHunt, IRun
{
    public void Hunt()
    {
        System.Console.WriteLine("El león ejecuta el método cazar. Es el rey de la selva.");
    }

    public void Run()
    {
        System.Console.WriteLine("El león ejecuta el método correr");
    }
}