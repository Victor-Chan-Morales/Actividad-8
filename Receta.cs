using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_8
{
    public class Receta
    {
        string Nombre { get; set; }
        double TiempoPreparación { get; set; }

        public Receta(string nombre, double tiempoPreparación)
        {
            Nombre = nombre;
            TiempoPreparación = tiempoPreparación;
        }
        
       public void PedirDatos()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Ingrese el nombre de la receta: ");
            string nombreReceta = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Ingrese el tiempo de preparación en minutos");
                double tiempoReceta=double.Parse(Console.ReadLine());
                if (tiempoReceta < 0)
                {
                    Console.WriteLine("No puede agregar un tiempo menor o igual a cero.");
                }
                else
                {
                    break;
                }
            }
        }
        public void BuscarReceta(List<Receta>lista)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Ingrese el nombre de la receta a buscar");
            string nombreABuscar=Console.ReadLine();
            Receta verificarReceta=lista.Find(c=>c.Nombre.Equals(nombreABuscar));
            if (verificarReceta != null)
            {
                Console.WriteLine($"El producto {nombreABuscar} se encuentra registrado y tiene un tiempo de preparación de {verificarReceta.TiempoPreparación}");
            }
            else
            {
                Console.WriteLine("El producto no se encuentra registrado");
            }
        }
    }


    
}
