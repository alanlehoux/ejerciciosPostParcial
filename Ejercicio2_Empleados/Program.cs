namespace Ejercicio2_Empleados
{
    internal class Program
    {
        static List<Empleado> listaEmpleados = new List<Empleado>();

        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.WriteLine("\nSISTEMA DE EMPLEADOS");
                Console.WriteLine("1. Agregar Empleado");
                Console.WriteLine("2. Modificar Empleado");
                Console.WriteLine("3. Eliminar Empleado");
                Console.WriteLine("4. Listar Empleados");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccioná una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarEmpleado();
                        break;

                    case 2:
                        ModificarEmpleado();
                        break;

                    case 3:
                        EliminarEmpleado();
                        break;

                    case 4:
                        ListarEmpleados();
                        break;
                }

            } while (opcion != 5);
        }

        static void AgregarEmpleado()
        {
            Console.WriteLine("\nTipo de empleado:");
            Console.WriteLine("1. Permanente");
            Console.WriteLine("2. Temporal");
            int tipo = int.Parse(Console.ReadLine());

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Sueldo Base: ");
            float sueldo = float.Parse(Console.ReadLine());

            Empleado nuevo = null;

            if (tipo == 1)
            {
                Console.Write("Años de antigüedad: ");
                int años = int.Parse(Console.ReadLine());
                nuevo = new EmpleadoPermanente(id, nombre, apellido, sueldo, años);
            }
            else if (tipo == 2)
            {
                Console.Write("Meses de contrato: ");
                int meses = int.Parse(Console.ReadLine());
                nuevo = new EmpleadoTemporal(id, nombre, apellido, sueldo, meses);
            }

            listaEmpleados.Add(nuevo);
        }

        static void ModificarEmpleado()
        {
            Console.Write("\nIngresá el ID del empleado a modificar: ");
            int id = int.Parse(Console.ReadLine());

            foreach (var e in listaEmpleados)
            {
                if (e.GetId() == id)
                {
                    Console.Write("Nuevo Nombre: ");
                    e.SetNombre(Console.ReadLine());
                    Console.Write("Nuevo Apellido: ");
                    e.SetApellido(Console.ReadLine());
                    Console.Write("Nuevo Sueldo Base: ");
                    e.SetSueldoBase(float.Parse(Console.ReadLine()));
                    return;
                }
            }

            Console.WriteLine("Empleado no encontrado.");
        }

        static void EliminarEmpleado()
        {
            Console.Write("\nIngresá el ID del empleado a eliminar: ");
            int id = int.Parse(Console.ReadLine());

            listaEmpleados.RemoveAll(e => e.GetId() == id);
        }

        static void ListarEmpleados()
        {
            Console.WriteLine("\nLISTA DE EMPLEADOS");
            foreach (var e in listaEmpleados)
            {
                e.MostrarDatos();
                Console.WriteLine("  ");
            }
        }
    }
}