public class Camion : Vehiculo
{
    protected float CapacidadCarga;

    public Camion(int id, string marca, string modelo, int año, float capacidadCarga)
        : base(id, marca, modelo, año)
    {
        CapacidadCarga = capacidadCarga;
    }

    public override void MostrarDatos()
    {
        base.MostrarDatos();
        Console.WriteLine($"Capacidad de carga: {CapacidadCarga} kg");
    }
}