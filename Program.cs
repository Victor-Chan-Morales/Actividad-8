using Actividad_8;

List<Receta> listaRecetas = new List<Receta>();
Receta NuevaLista = new Receta("", 0);
bool ingresar = false;
do
{
    Console.Clear();
    Console.WriteLine("Menú principal\n1. Registrar una receta\n2. Buscar una receta\n. 3. Ver recetas disponibles\n4. Salir del programa\nSeleccione una opción:");
    int opciónMenú=int.Parse(Console.ReadLine());
    switch(opciónMenú)
    {
        case 1:
            NuevaLista.PedirDatos();
            listaRecetas.Add(NuevaLista);
            break;
        case 2:
            NuevaLista.BuscarReceta(listaRecetas);
            break;
        case 3:
            NuevaLista.MostrarRecetas(listaRecetas);
            break;
        case 4:
            ingresar = false;
            break;
    }

} while (ingresar);

