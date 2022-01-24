using ISP.Interfaces;
public class ReportRepository : IReadable
{
    public void Get(int id)
    {
        System.Console.WriteLine($"Se devuelve el ítem con id {id}");
    }

    public void GetAll()
    {
        System.Console.WriteLine("Se devuelven todos los registros");
    }
}