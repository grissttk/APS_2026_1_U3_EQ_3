using Clase_ICDIA_Unidad3.TareaModels;

namespace Clase_ICDIA_Unidad3.TareaRunners;

public class RunnerT04_Pasatiempos
{
    public RunnerT04_Pasatiempos()
    {
        int opcion = 0;
        do
        {
            Console.WriteLine("ingresa el numero de la seccion deseada");
            Console.WriteLine("1: registro pasatiempo");
            Console.WriteLine("0: salir");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("ingresa el nombre del pasatiempo");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingresa la descripcion");
                    string descripcion = Console.ReadLine();
                    Console.WriteLine("ingresa las horas que le dedicas a la semana");
                    int horas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingresa el costo mensual aproximado");
                    double costo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("¿requiere equipo especial? (true/false)");
                    bool equipo = Convert.ToBoolean(Console.ReadLine());

                    Pasatiempo hobby = new Pasatiempo(nombre, descripcion, horas, costo, equipo);

                    //guardar pasatiempo
                    StreamWriter sw = new StreamWriter("registro_pasatiempos.csv", true);
                    sw.WriteLine(hobby.Nombre + "," + hobby.Descripcion + "," + hobby.HorasSemanales + "," + hobby.CostoMensual + "," + hobby.RequiereEquipo);
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