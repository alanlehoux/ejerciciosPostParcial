public class Producto
{
    protected int Id;
    protected string Nombre;
    protected float PrecioBase;

    public Producto(int id, string nombre, float precio)
    {
        Id = id;
        Nombre = nombre;
        PrecioBase = precio;
    }

    public int GetId() => Id;
    public void SetNombre(string nombre) => Nombre = nombre;
    public void SetPrecioBase(float precio) => PrecioBase = precio;

    public virtual void MostrarDatos()
    {
        Console.WriteLine($"ID: {Id} - {Nombre} - Precio Base: {PrecioBase}");
    }
}
