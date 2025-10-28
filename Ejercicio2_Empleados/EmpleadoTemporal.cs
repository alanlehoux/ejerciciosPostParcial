public class EmpleadoTemporal : Empleado
{
    protected int MesesContrato;

    public EmpleadoTemporal(int id, string nombre, string apellido, float sueldo, int meses)
        : base(id, nombre, apellido, sueldo)
    {
        MesesContrato = meses;
    }

    public override float CalcularSueldo()
    {
        return SueldoBase;
    }

    public override void MostrarDatos()
    {
        base.MostrarDatos();
        Console.WriteLine($"Contrato por: {MesesContrato} meses - Sueldo Final: {CalcularSueldo()}");
    }
}