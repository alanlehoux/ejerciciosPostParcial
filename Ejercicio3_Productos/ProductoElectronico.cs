public class ProductoElectronico : Producto
{
    protected int MesesGarantia;

    public ProductoElectronico(int id, string nombre, float precio, int meses)
        : base(id, nombre, precio)
    {
        MesesGarantia = meses;
    }

    public override void MostrarDatos()
    {
        base.MostrarDatos();
        Console.WriteLine($"Meses de Garantía: {MesesGarantia}");
    }
}
