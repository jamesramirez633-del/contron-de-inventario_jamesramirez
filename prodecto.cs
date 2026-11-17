using System;

namespace TecnoPunto
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(" SISTEMA DE INVENTARIO TECNOPUNTO");
           

            Console.WriteLine("Registre tres productos.");
            Console.WriteLine();

            // Creación de tres objetos.
            Producto producto1 = CrearProducto(1);
            Producto producto2 = CrearProducto(2);
            Producto producto3 = CrearProducto(3);

            // Mostrar los productos registrados.
            Console.WriteLine();
            Console.WriteLine("INVENTARIO REGISTRADO ");

            producto1.MostrarInfo();
            producto2.MostrarInfo();
            producto3.MostrarInfo();

            Console.WriteLine();
            Console.WriteLine("Registro finalizado correctamente.");

            Console.ReadKey();
        }

        static Producto CrearProducto(int numero)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("----- PRODUCTO " + numero + " -----");

                Console.Write("Código: ");
                string codigo = Console.ReadLine() ?? "";

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine() ?? "";

                decimal precio = LeerDecimal("Precio: ");

                int cantidad = LeerEntero("Cantidad: ");

                try
                {
                    Producto nuevoProducto = new Producto(
                        codigo,
                        nombre,
                        precio,
                        cantidad
                    );

                    Console.WriteLine(
                        "Producto registrado correctamente."
                    );

                    return nuevoProducto;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine();
                    Console.WriteLine("ERROR: " + ex.Message);
                    Console.WriteLine(
                        "Introduzca nuevamente los datos."
                    );
                }
            }
        }

        // Leer y validar números decimales.
        static decimal LeerDecimal(string mensaje)
        {
            decimal valor;

            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine() ?? "";

                if (decimal.TryParse(entrada, out valor))
                {
                    return valor;
                }

                Console.WriteLine(
                    "Entrada inválida. Escriba un número válido."
                );
            }
        }

        // Leer y validar números enteros.
        static int LeerEntero(string mensaje)
        {
            int valor;

            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine() ?? "";

                if (int.TryParse(entrada, out valor))
                {
                    return valor;
                }

                Console.WriteLine(
                    "Entrada inválida. Escriba un número entero."
                );
            }
        }
    }
}
