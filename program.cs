using System;

namespace TecnoPunto
{
    // Clase que representa un producto del inventario.
    public class Producto
    {
        public string Codigo { get; set; }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "El nombre del producto no puede estar vacío."
                    );
                }

                nombre = value.Trim();
            }
        }

        private decimal precio;
        public decimal Precio
        {
            get { return precio; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(Precio),
                        "El precio debe ser mayor que 0."
                    );
                }

                precio = value;
            }
        }

        private int cantidad;
        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(Cantidad),
                        "La cantidad no puede ser negativa."
                    );
                }

                cantidad = value;
            }
        }

        
        public decimal ValorTotal
        {
            get { return Precio * Cantidad; }
        }

        public Producto(string codigo, string nombre,
                        decimal precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        // Método para mostrar la información.
        public void MostrarInfo()
        {
            
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio unitario: " + Precio.ToString("C"));
            Console.WriteLine("Cantidad disponible: " + Cantidad);
            Console.WriteLine("Valor total: " + ValorTotal.ToString("C"));
         
        }
    }
}
