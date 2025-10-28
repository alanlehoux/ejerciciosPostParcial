public class EmpleadoPermanente : Empleado
{
    protected int AniosAntiguedad;

    public EmpleadoPermanente(int id, string nombre, string apellido, float sueldo, int antiguedad)
        : base(id, nombre, apellido, sueldo)
    {
        AniosAntiguedad = antiguedad;
    }

    public override float CalcularSueldo()
    {
        return SueldoBase + (AniosAntiguedad * 1000);
    }

    public override void MostrarDatos()
    {
        base.MostrarDatos();
        Console.WriteLine($"Antigüedad: {AniosAntiguedad} años - Sueldo Final: {CalcularSueldo()}");
    }
}