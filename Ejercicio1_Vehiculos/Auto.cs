public class Auto : Vehiculo
{
    protected int CantidadPuertas;

    public Auto(int id, string marca, string modelo, int año, int puertas)
        : base(id, marca, modelo, año)
    {
        CantidadPuertas = puertas;
    }

    public override void MostrarDatos()
    {
        base.MostrarDatos();
        Console.WriteLine($"Puertas: {CantidadPuertas}");
    }
}