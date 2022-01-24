using LSP.Interfaces;
namespace LSP.Animals;
public class Tiger : IHunt, IWalk, IRun
{
    public void Hunt()
    {
        System.Console.WriteLine("El tigre ejecutó el método cazar");
    }

    public void Run()
    {
        System.Console.WriteLine("El tigre ejecutó el método correr");
    }

    public void Walk()
    {
        System.Console.WriteLine("El tigre ejecutó el método caminar");
    }
}