public class Empleado
{
    protected int Id;
    protected string Nombre;
    protected string Apellido;
    protected float SueldoBase;

    public Empleado(int id, string nombre, string apellido, float sueldo)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        SueldoBase = sueldo;
    }

    public int GetId() => Id;
    public void SetNombre(string nombre) => Nombre = nombre;
    public void SetApellido(string apellido) => Apellido = apellido;
    public void SetSueldoBase(float sueldo) => SueldoBase = sueldo;

    public virtual float CalcularSueldo()
    {
        return SueldoBase;
    }

    public virtual void MostrarDatos()
    {
        Console.WriteLine($"ID: {Id} - {Nombre} {Apellido} - Sueldo Base: {SueldoBase}");
    }
}