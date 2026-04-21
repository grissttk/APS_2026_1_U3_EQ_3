using Clase_ICDIA_Unidad3.TareaModels;

namespace Clase_ICDIA_Unidad3.TareaRunners;

public class RunnerT07_Musica
{
    public RunnerT07_Musica()
    {
        int opcion = 0;
        do
        {
            Console.WriteLine("ingresa el numero de la seccion deseada");
            Console.WriteLine("1: registro deporte");
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

                    Deporte deporte = new Deporte(nombre, tipo, jugadores, olimpico, duracion);

                    //guardar deporte
                    StreamWriter sw = new StreamWriter("registro_deportes.csv", true);
                    sw.WriteLine(deporte.Nombre + "," + deporte.Tipo + "," + deporte.NumeroJugadores + "," + deporte.EsOlimpico + "," + deporte.DuracionPromedioMinutos);
                    sw.Flush();
                    sw.Close();
                    break;
                case 0:
                    Console.WriteLine("gracias por usar el programa");
                    break;
            }
        } while (opcion != 0);
    }
}