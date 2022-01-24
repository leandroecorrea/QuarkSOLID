using ISP.Interfaces;
public class UserRepository : IReadable, IWriteable, IRemovable
{
    public void Create()
    {
        System.Console.WriteLine("Se creó un nuevo registro");
    }

    public void Get(int id)
    {
        System.Console.WriteLine($"Se devuelve un registro con ID {id}, si existe");
    }

    public void GetAll()
    {
        System.Console.WriteLine("Se devuelven todos los resultados existentes");
    }

    public void Remove(int id)
    {
        System.Console.WriteLine($"Se elimina el ítem con id {id}");
    }

    public void Update()
    {
        System.Console.WriteLine($"Se actualizó el registro");
    }
}