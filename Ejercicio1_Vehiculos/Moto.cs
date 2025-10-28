public class Moto : Vehiculo
{
    protected float Cilindrada;

    public Moto(int id, string marca, string modelo, int año, float cilindrada)
        : base(id, marca, modelo, año)
    {
        Cilindrada = cilindrada;
    }

    public override void MostrarDatos()
    {
        base.MostrarDatos();
        Console.WriteLine($"Cilindrada: {Cilindrada} cc");
    }
}