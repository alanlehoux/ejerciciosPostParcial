using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    internal class Program
    {
        // Lista de vehículos
        static List<Vehiculo> listaVehiculos = new List<Vehiculo>();

        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.WriteLine("\nGESTIÓN DE VEHÍCULOS");
                Console.WriteLine("1. Agregar vehículo");
                Console.WriteLine("2. Modificar vehículo");
                Console.WriteLine("3. Eliminar vehículo");
                Console.WriteLine("4. Listar todos");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccioná una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarVehiculo();
                        break;

                    case 2:
                        ModificarVehiculo();
                        break;

                    case 3:
                        EliminarVehiculo();
                        break;

                    case 4:
                        ListarVehiculos();
                        break;
                }

            } while (opcion != 5);
        }

        static void AgregarVehiculo()
        {
            Console.WriteLine("\nTipo de vehículo a agregar:");
            Console.WriteLine("1. Auto");
            Console.WriteLine("2. Moto");
            Console.WriteLine("3. Camion");
            int tipo = int.Parse(Console.ReadLine());

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Marca: ");
            string marca = Console.ReadLine();
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Año: ");
            int año = int.Parse(Console.ReadLine());

            Vehiculo nuevo = null;

            if (tipo == 1)
            {
                Console.Write("Cantidad de puertas: ");
                int puertas = int.Parse(Console.ReadLine());
                nuevo = new Auto(id, marca, modelo, año, puertas);
            }
            else if (tipo == 2)
            {
                Console.Write("Cilindrada: ");
                float cilindrada = float.Parse(Console.ReadLine());
                nuevo = new Moto(id, marca, modelo, año, cilindrada);
            }
            else if (tipo == 3)
            {
                Console.Write("Capacidad de carga: ");
                float carga = float.Parse(Console.ReadLine());
                nuevo = new Camion(id, marca, modelo, año, carga);
            }

            listaVehiculos.Add(nuevo);
        }

        static void ModificarVehiculo()
        {
            Console.Write("\nIngresá el ID del vehículo a modificar: ");
            int id = int.Parse(Console.ReadLine());

            foreach (var v in listaVehiculos)
            {
                if (v.GetId() == id)
                {
                    Console.Write("Nueva marca: ");
                    v.SetMarca(Console.ReadLine());
                    Console.Write("Nuevo modelo: ");
                    v.SetModelo(Console.ReadLine());
                    Console.Write("Nuevo año: ");
                    v.SetAño(int.Parse(Console.ReadLine()));
                    return;
                }
            }
            Console.WriteLine("Vehículo no encontrado.");
        }

        static void EliminarVehiculo()
        {
            Console.Write("\nIngresá el ID del vehículo a eliminar: ");
            int id = int.Parse(Console.ReadLine());

            listaVehiculos.RemoveAll(v => v.GetId() == id);
        }

        static void ListarVehiculos()
        {
            Console.WriteLine("\nLISTA DE VEHÍCULOS");
            foreach (var v in listaVehiculos)
            {
                v.MostrarDatos();
                Console.WriteLine(" ");
            }
        }
    }
}