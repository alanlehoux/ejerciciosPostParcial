public class Persona
{
    protected int id;
    protected string nombre;
    protected int edad;

    public int Id { get { return id; } set { id = value; } }
    public string Nombre { get { return nombre; } set { nombre = value; } }
    public int Edad { get { return edad; } set { edad = value; } }

    public Persona() { }

    public Persona(int id, string nombre, int edad)
    {
        this.id = id;
        this.nombre = nombre;
        this.edad = edad;
    }

    public virtual void MostrarDatos()
    {
        Console.WriteLine($"ID: {id} | Nombre: {nombre} | Edad: {edad}");
    }
}