public class ProductoAlimenticio : Producto
{
    protected string FechaVencimiento;

    public ProductoAlimenticio(int id, string nombre, float precio, string fecha)
        : base(id, nombre, precio)
    {
        FechaVencimiento = fecha;
    }

    public override void MostrarDatos()
    {
        base.MostrarDatos();
        Console.WriteLine($"Fecha de Vencimiento: {FechaVencimiento}");
    }
}
