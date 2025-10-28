public class Vehiculo
{
    protected int Id;
    protected string Marca;
    protected string Modelo;
    protected int Año;

    public Vehiculo(int id, string marca, string modelo, int año)
    {
        Id = id;
        Marca = marca;
        Modelo = modelo;
        Año = año;
    }

    public int GetId() => Id;
    public void SetMarca(string marca) => Marca = marca;
    public void SetModelo(string modelo) => Modelo = modelo;
    public void SetAño(int año) => Año = año;

    public virtual void MostrarDatos()
    {
        Console.WriteLine($"ID: {Id} - {Marca} {Modelo} ({Año})");
    }
}
