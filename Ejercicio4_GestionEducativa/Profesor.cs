public class Profesor : Persona
{
    protected string materia;
    protected float sueldo;

    public string Materia { get { return materia; } set { materia = value; } }
    public float Sueldo { get { return sueldo; } set { sueldo = value; } }

    public Profesor() { }

    public Profesor(int id, string nombre, int edad, string materia, float sueldo)
        : base(id, nombre, edad)
    {
        this.materia = materia;
        this.sueldo = sueldo;
    }

    public override void MostrarDatos()
    {
        Console.WriteLine($"[Profesor] ID: {id} | Nombre: {nombre} | Edad: {edad} | Materia: {materia} | Sueldo: {sueldo}");
    }
}