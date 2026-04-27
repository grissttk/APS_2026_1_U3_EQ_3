using Clase_ICDIA_Unidad3.TareaModels;

namespace Clase_ICDIA_Unidad3.TareaRunners;

public class RunnerT05_Musica
{
    public RunnerT05_Musica()
    {
        string ruta = "registro_Musica.csv";
        List<Musica> musicas = new List<Musica>();
        
        if (File.Exists(ruta))
        {
            foreach (string linea in File.ReadLines(ruta))
            {
                string[] datos = linea.Split(',');
                string titulo = datos[0];
                string artista = datos[1];
                string genero  = datos[2];
                int anioLanzamiento = Convert.ToInt32(datos[3]);
                double duracionMinutos = Convert.ToDouble(datos[4]);
                Musica mu = new Musica(titulo, artista, genero, anioLanzamiento, duracionMinutos);
                musicas.Add(mu);
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
                    Console.WriteLine("ingresa el titulo de la cancion");
                    string titulo = Console.ReadLine();
                    
                    Console.WriteLine("ingresa el artista de la cancion");
                    string artista = Console.ReadLine();
                    
                    Console.WriteLine("ingresa el genero de la cancion");
                    string genero = Console.ReadLine();
                    
                    Console.WriteLine("ingresa el año de lanzamiento");
                    int anioLanzamiento = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("ingresa la duracion de la cancion en minutos");
                    double duracionMinutos = Convert.ToDouble(Console.ReadLine());

                    Musica musica = new Musica(titulo, artista, genero, anioLanzamiento, duracionMinutos);

                    //guardar deporte
                    StreamWriter sw = new StreamWriter("registro_Musica.csv", true);
                    sw.WriteLine(musica.Titulo + "," + musica.Artista + "," + musica.Genero + "," + musica.AnioLanzamiento + "," + musica.DuracionMinutos);
                    sw.Flush();
                    sw.Close();
                    
                    // Verificar si ya existe (por nombre)
                    bool existe = musicas.Any(c => c.Titulo == titulo);

                    if (existe)
                    {
                        Console.WriteLine("La comida ya está registrada");
                    }
                    else
                    {
                        Musica musicaa = new Musica(titulo,  artista, genero, anioLanzamiento, duracionMinutos);
                        musicas.Add(musicaa);
                    }
                    Console.WriteLine();
                    break;
                
                case 2:
                    Console.WriteLine("Lista de canciones registradas:");
                    foreach (Musica musicaa in musicas)
                    {
                        Console.WriteLine(musicaa);
                    }
                    Console.WriteLine();
                    break;
                
                case 3:
                    Console.WriteLine("Ingresa el nombre de la canción a eliminar:");
                    string tituloEliminar = Console.ReadLine();

                    Musica musicaEliminar = musicas.FirstOrDefault(c => c.Titulo == tituloEliminar);

                    if (musicaEliminar != null)
                    {
                        musicas.Remove(musicaEliminar);
                        Console.WriteLine("Registro eliminado");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró la canción");
                    }
                    Console.WriteLine();
                    break;
                
                case 4:
                    StreamWriter swr = new StreamWriter(ruta);

                    foreach (Musica musicaa in musicas)
                    {
                        swr.WriteLine(musicaa.Titulo + "," + musicaa.Artista + "," + musicaa.Genero + "," + musicaa.AnioLanzamiento + "," + musicaa.DuracionMinutos);
                    }
                    swr.Close();
                    Console.WriteLine("Cambios guardados");
                    Console.WriteLine();
                    break;
                
                case 5:
                    musicas = musicas.OrderBy(c => c.Titulo).ToList();
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