using LSP.Interfaces;
namespace LSP.Animals;
public class Turtle : IWalk
{
    public void Walk()
    {
        System.Console.WriteLine("La tortuga ejecutó el método caminar. Lo hace lentamente!");
    }
}