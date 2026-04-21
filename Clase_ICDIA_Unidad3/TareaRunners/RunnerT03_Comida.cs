using Clase_ICDIA_Unidad3.TareaModels;

namespace Clase_ICDIA_Unidad3.TareaRunners;

public class RunnerT03_Comida
{
    public RunnerT03_Comida()
    {
        int opcion = 0;
        do
        {
            Console.WriteLine("ingresa el numero de la seccion deseada");
            Console.WriteLine("1: registro comida");
            Console.WriteLine("0: salir");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("ingresa el nombre de la comida");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingresa la categoria (ej. Mexicana, Italiana)");
                    string categoria = Console.ReadLine();
                    Console.WriteLine("ingresa el precio");
                    double precio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ingresa las calorias");
                    int calorias = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingresa si es picante (true/false)");
                    bool esPicante = Convert.ToBoolean(Console.ReadLine());

                    Comida comida = new Comida(nombre, categoria, precio, calorias, esPicante);

                    //guardar comida
                    StreamWriter sw = new StreamWriter("registro_comidas.csv", true);
                    sw.WriteLine(comida.Nombre + "," + comida.Categoria + "," + comida.Precio + "," + comida.Calorias + "," + comida.EsPicante);
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