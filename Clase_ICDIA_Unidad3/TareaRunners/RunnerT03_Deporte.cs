using Clase_ICDIA_Unidad3.TareaModels;

namespace Clase_ICDIA_Unidad3.TareaRunners;

public class RunnerT03_Deporte
{
    public RunnerT03_Deporte()
    {
        string ruta = "registro_Deporte.csv";
        List<Deporte> deportes = new List<Deporte>();
        
        if (File.Exists(ruta))
        {
            foreach (string linea in File.ReadLines(ruta))
            {
                string[] datos = linea.Split(',');
                string nombre = datos[0];
                string tipo = datos[1];
                int numeroJugadores  = Convert.ToInt32(datos[2]);
                bool esOlimpico = Convert.ToBoolean(datos[3]);
                double duracionPromedioMinutos = Convert.ToDouble(datos[4]);
                Deporte dep = new Deporte(nombre, tipo, numeroJugadores, esOlimpico, duracionPromedioMinutos);
                deportes.Add(dep);
            }
        }
        else
        {
            Console.WriteLine("No existen registro previos");
        }
        
        int opcion = 0;
        do
        {
            Console.WriteLine("ingresa el numero de la seccion deseada");
            Console.WriteLine("1: registro deporte");
            Console.WriteLine("2: Visualizar todos los registros");
            Console.WriteLine("3: Eliminar registro");
            Console.WriteLine("4: Guardar cambios");
            Console.WriteLine("5: Ordenar");
            Console.WriteLine("0: salir");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("ingresa el nombre del deporte");
                    string nombre = Console.ReadLine();
                    
                    Console.WriteLine("ingresa el tipo -ej. Equipo, Individual-");
                    string tipo = Console.ReadLine();
                    
                    Console.WriteLine("ingresa el numero de jugadores por lado");
                    int jugadores = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("¿es un deporte olímpico? (true/false)");
                    bool olimpico = Convert.ToBoolean(Console.ReadLine());
                    
                    Console.WriteLine("ingresa la duracion promedio de un partido/evento en minutos");
                    double duracion = Convert.ToDouble(Console.ReadLine());

                    Deporte deportee = new Deporte(nombre, tipo, jugadores, olimpico, duracion);

                    //guardar deporte
                    StreamWriter sw = new StreamWriter("registro_deportes.csv", true);
                    sw.WriteLine(deportee.Nombre + "," + deportee.Tipo + "," + deportee.NumeroJugadores + "," + deportee.EsOlimpico + "," + deportee.DuracionPromedioMinutos);
                    sw.Flush();
                    sw.Close();
                    
                    bool existe = deportes.Any(c => c.Nombre == nombre);

                    if (existe)
                    {
                        Console.WriteLine("La comida ya está registrada");
                    }
                    else
                    {
                        Deporte deporte = new Deporte(nombre, tipo, jugadores, olimpico, duracion);
                        deportes.Add(deporte);
                    }
                    Console.WriteLine();
                    break;
                
                case 2:
                    Console.WriteLine("Lista de deportes registrados:");
                    foreach (Deporte deporte in deportes)
                    {
                        Console.WriteLine(deporte);
                    }
                    Console.WriteLine();
                    break;
                
                case 3:
                    Console.WriteLine("Ingresa el nombre de la comida a eliminar:");
                    string nombreEliminar = Console.ReadLine();

                    Deporte deporteEliminar = deportes.FirstOrDefault(c => c.Nombre == nombreEliminar);

                    if (deporteEliminar != null)
                    {
                        deportes.Remove(deporteEliminar);
                        Console.WriteLine("Registro eliminado");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró el deporte");
                    }
                    Console.WriteLine();
                    break;
                
                case 4:
                    StreamWriter swr = new StreamWriter(ruta);

                    foreach (Deporte deporte in deportes)
                    {
                        swr.WriteLine(deporte.Nombre + "," + deporte.Tipo + "," + deporte.NumeroJugadores + "," + deporte.EsOlimpico + "," + deporte.DuracionPromedioMinutos);
                    }
                    swr.Close();
                    Console.WriteLine("Cambios guardados");
                    Console.WriteLine();
                    break;
                
                case 5:
                    deportes = deportes.OrderBy(c => c.Nombre).ToList();
                    Console.WriteLine("Registros ordenados por nombre");
                    Console.WriteLine();
                    break;
                
                case 0:
                    Console.WriteLine("Gracias por usar el programa");
                    break;
            }
        } while (opcion != 0);
    }
}