using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_8
{
    public class Receta
    {
        public string Nombre { get; set; }
        public double TiempoPreparación { get; set; }

        public Receta(string nombre, double tiempoPreparación)
        {
            Nombre = nombre;
            TiempoPreparación = tiempoPreparación;
        }
        
       public static Receta PedirDatos()
        {
            Console.Clear();
            Console.Write("Ingrese el nombre de la receta: ");
            string nombreReceta = Console.ReadLine().ToUpper();
            double tiempoReceta;
            while (true)
            {
                Console.Write("Ingrese el tiempo de preparación en minutos: ");
                tiempoReceta=double.Parse(Console.ReadLine());
                if (tiempoReceta < 0)
                {
                    Console.WriteLine("No puede agregar un tiempo menor o igual a cero.");
                }
                else
                {
                    break;
                }
            }
            return new Receta(nombreReceta,tiempoReceta);
        }
        public static void BuscarReceta(List<Receta>lista)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre de la receta a buscar");
            string nombreABuscar=Console.ReadLine().ToUpper();
            Receta verificarReceta=lista.Find(c=>c.Nombre.Equals(nombreABuscar));
            if (verificarReceta != null)
            {
                Console.WriteLine($"El producto {nombreABuscar} se encuentra registrado y tiene un tiempo de preparación de {verificarReceta.TiempoPreparación} minutos");
            }
            else
            {
                Console.WriteLine("El producto no se encuentra registrado");
            }
        }
        public static void MostrarRecetas(List<Receta>lista)
        {
            Console.Clear();
            Console.WriteLine("RECETAS DISPONIBLES");
           foreach (Receta rec in lista)
           {
               Console.WriteLine($"* Nombre de la receta: {rec.Nombre} con un tiempo de preparación de: {rec.TiempoPreparación} minutos");
           }  
        }
    }


    
}
