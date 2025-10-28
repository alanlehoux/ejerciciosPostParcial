public class Alumno : Persona
{
    protected int legajo;
    protected float promedio;

    public int Legajo { get { return legajo; } set { legajo = value; } }
    public float Promedio { get { return promedio; } set { promedio = value; } }

    public Alumno() { }

    public Alumno(int id, string nombre, int edad, int legajo, float promedio)
        : base(id, nombre, edad)
    {
        this.legajo = legajo;
        this.promedio = promedio;
    }

    public override void MostrarDatos()
    {
        Console.WriteLine($"[Alumno] ID: {id} | Nombre: {nombre} | Edad: {edad} | Legajo: {legajo} | Promedio: {promedio}");
    }
}
