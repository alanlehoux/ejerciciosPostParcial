class Program
{
    static List<Persona> personas = new List<Persona>();

    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine("\nGestión Educativa");
            Console.WriteLine("1. Agregar Persona");
            Console.WriteLine("2. Modificar Persona");
            Console.WriteLine("3. Eliminar Persona");
            Console.WriteLine("4. Listar Personas");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccioná una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: AgregarPersona(); break;
                case 2: ModificarPersona(); break;
                case 3: EliminarPersona(); break;
                case 4: ListarPersonas(); break;
            }

        } while (opcion != 0);
    }

    static void AgregarPersona()
    {
        Console.WriteLine("\n1. Alumno\n2. Profesor");
        Console.Write("Tipo: ");
        int tipo = int.Parse(Console.ReadLine());

        Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
        Console.Write("Nombre: "); string nombre = Console.ReadLine();
        Console.Write("Edad: "); int edad = int.Parse(Console.ReadLine());

        if (tipo == 1)
        {
            Console.Write("Legajo: "); int legajo = int.Parse(Console.ReadLine());
            Console.Write("Promedio: "); float prom = float.Parse(Console.ReadLine());
            personas.Add(new Alumno(id, nombre, edad, legajo, prom));
        }
        else
        {
            Console.Write("Materia: "); string materia = Console.ReadLine();
            Console.Write("Sueldo: "); float sueldo = float.Parse(Console.ReadLine());
            personas.Add(new Profesor(id, nombre, edad, materia, sueldo));
        }
    }

    static void ModificarPersona()
    {
        Console.Write("Ingresá el ID a modificar: ");
        int id = int.Parse(Console.ReadLine());

        foreach (var p in personas)
        {
            if (p.Id == id)
            {
                Console.Write("Nuevo nombre: "); p.Nombre = Console.ReadLine();
                Console.Write("Nueva edad: "); p.Edad = int.Parse(Console.ReadLine());
                return;
            }
        }

        Console.WriteLine("No encontrado.");
    }

    static void EliminarPersona()
    {
        Console.Write("ID a eliminar: ");
        int id = int.Parse(Console.ReadLine());
        personas.RemoveAll(p => p.Id == id);
    }

    static void ListarPersonas()
    {
        Console.WriteLine("\nListado General");
        foreach (var p in personas)
            p.MostrarDatos();
    }
}