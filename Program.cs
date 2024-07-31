using Actividad_8;

List<Receta> listaRecetas = new List<Receta>();
Receta NuevaLista = new Receta("", 0);
bool ingresar = true;
do
{
    Console.Clear();
    Console.WriteLine("Menú principal\n1. Registrar una receta\n2. Buscar una receta\n3. Ver recetas disponibles\n4. Salir del programa\nSeleccione una opción:");
    int opciónMenú=int.Parse(Console.ReadLine());
    switch(opciónMenú)
    {
        case 1:
            Receta recetaNueva=Receta.PedirDatos();
            listaRecetas.Add(recetaNueva);
            Console.ReadKey();
            break;
        case 2:
            Receta.BuscarReceta(listaRecetas);
            Console.ReadKey();
            break;
        case 3:
            Receta.MostrarRecetas(listaRecetas);
            Console.ReadKey();
            break;
        case 4:
            ingresar = false;
            break;
    }
} while (ingresar);

