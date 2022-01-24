using LSP.Interfaces;
namespace LSP.Animals;
public class Antilope : IWalk, IRun
{
    public void Run()
    {
        System.Console.WriteLine("El antílope ejecutó el método correr");
    }

    public void Walk()
    {
        System.Console.WriteLine("El antílope ejecutó el método caminar");
    }
}