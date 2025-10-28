using System;
using System.Collections.Generic;

namespace Ejercicio5_Bancario
{
    internal class Program
    {
        static List<Cuenta> cuentas = new List<Cuenta>();

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\nSISTEMA BANCARIO");
                Console.WriteLine("1. Registrar cuenta");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Extraer");
                Console.WriteLine("4. Aplicar intereses / actualizar saldo");
                Console.WriteLine("5. Listar cuentas");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: RegistrarCuenta(); break;
                    case 2: Depositar(); break;
                    case 3: Extraer(); break;
                    case 4: ActualizarSaldos(); break;
                    case 5: ListarCuentas(); break;
                }

            } while (opcion != 0);
        }

        static void RegistrarCuenta()
        {
            Console.WriteLine("\nTipo de cuenta:");
            Console.WriteLine("1. Caja de Ahorro");
            Console.WriteLine("2. Cuenta Corriente");
            int tipo = int.Parse(Console.ReadLine());

            Console.Write("Número de cuenta: "); int num = int.Parse(Console.ReadLine());
            Console.Write("Titular: "); string titular = Console.ReadLine();
            Console.Write("Saldo inicial: "); float saldo = float.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                Console.Write("Tasa de interés (%): "); float tasa = float.Parse(Console.ReadLine());
                cuentas.Add(new CajaAhorro(num, titular, saldo, tasa));
            }
            else
            {
                Console.Write("Límite descubierto: "); float limite = float.Parse(Console.ReadLine());
                cuentas.Add(new CuentaCorriente(num, titular, saldo, limite));
            }
        }

        static void Depositar()
        {
            Console.Write("Número de cuenta: "); int num = int.Parse(Console.ReadLine());
            Console.Write("Monto a depositar: "); float monto = float.Parse(Console.ReadLine());

            foreach (var c in cuentas)
            {
                if (c.GetNumeroCuenta() == num)
                {
                    c.Depositar(monto);
                    Console.WriteLine("Depósito realizado.");
                    return;
                }
            }
            Console.WriteLine("Cuenta no encontrada.");
        }

        static void Extraer()
        {
            Console.Write("Número de cuenta: "); int num = int.Parse(Console.ReadLine());
            Console.Write("Monto a extraer: "); float monto = float.Parse(Console.ReadLine());

            foreach (var c in cuentas)
            {
                if (c.GetNumeroCuenta() == num)
                {
                    if (c.Extraer(monto))
                        Console.WriteLine("Extracción realizada.");
                    else
                        Console.WriteLine("Saldo insuficiente.");
                    return;
                }
            }
            Console.WriteLine("Cuenta no encontrada.");
        }

        static void ActualizarSaldos()
        {
            foreach (var c in cuentas)
                c.ActualizarSaldo();

            Console.WriteLine("Saldos actualizados.");
        }

        static void ListarCuentas()
        {
            Console.WriteLine("\nLISTADO DE CUENTAS");
            foreach (var c in cuentas)
            {
                Console.WriteLine($"Tipo: {c.GetType().Name}");
                c.MostrarDatos();
                Console.WriteLine("   ");
            }
        }
    }
}