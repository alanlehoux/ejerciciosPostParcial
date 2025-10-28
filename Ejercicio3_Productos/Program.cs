using System;
using System.Collections.Generic;

namespace Ejercicio3_Productos
{
    internal class Program
    {
        static List<Producto> listaProductos = new List<Producto>();

        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.WriteLine("\nINVENTARIO DE PRODUCTOS");
                Console.WriteLine("1. Agregar Producto");
                Console.WriteLine("2. Modificar Producto");
                Console.WriteLine("3. Eliminar Producto");
                Console.WriteLine("4. Listar Inventario");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccioná una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarProducto();
                        break;

                    case 2:
                        ModificarProducto();
                        break;

                    case 3:
                        EliminarProducto();
                        break;

                    case 4:
                        ListarProductos();
                        break;
                }

            } while (opcion != 5);
        }

        static void AgregarProducto()
        {
            Console.WriteLine("\nTipo de producto:");
            Console.WriteLine("1. Alimenticio");
            Console.WriteLine("2. Electrónico");
            int tipo = int.Parse(Console.ReadLine());

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Precio Base: ");
            float precio = float.Parse(Console.ReadLine());

            Producto nuevo = null;

            if (tipo == 1)
            {
                Console.Write("Fecha de Vencimiento (dd/mm/aaaa): ");
                string fecha = Console.ReadLine();
                nuevo = new ProductoAlimenticio(id, nombre, precio, fecha);
            }
            else if (tipo == 2)
            {
                Console.Write("Meses de Garantía: ");
                int meses = int.Parse(Console.ReadLine());
                nuevo = new ProductoElectronico(id, nombre, precio, meses);
            }

            listaProductos.Add(nuevo);
        }

        static void ModificarProducto()
        {
            Console.Write("\nIngresá el ID del producto a modificar: ");
            int id = int.Parse(Console.ReadLine());

            foreach (var p in listaProductos)
            {
                if (p.GetId() == id)
                {
                    Console.Write("Nuevo Nombre: ");
                    p.SetNombre(Console.ReadLine());
                    Console.Write("Nuevo Precio Base: ");
                    p.SetPrecioBase(float.Parse(Console.ReadLine()));
                    return;
                }
            }

            Console.WriteLine("Producto no encontrado.");
        }

        static void EliminarProducto()
        {
            Console.Write("\nIngresá el ID del producto a eliminar: ");
            int id = int.Parse(Console.ReadLine());

            listaProductos.RemoveAll(p => p.GetId() == id);
        }

        static void ListarProductos()
        {
            Console.WriteLine("\nINVENTARIO");
            foreach (var p in listaProductos)
            {
                Console.WriteLine($"Tipo: {p.GetType().Name}");
                p.MostrarDatos();
                Console.WriteLine("   ");
            }
        }
    }
}