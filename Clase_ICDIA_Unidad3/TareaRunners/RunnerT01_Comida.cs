using Clase_ICDIA_Unidad3.TareaModels;

namespace Clase_ICDIA_Unidad3.TareaRunners;

public class RunnerT01_Comida
{
    public RunnerT01_Comida()
    {
        string ruta = "registro_Comidas.csv";
        List<Comida> comidas = new List<Comida>();
        
        if (File.Exists(ruta))
        {
            foreach (string linea in File.ReadLines(ruta))
            {
                string[] datos = linea.Split(',');
                string nombre = datos[0];
                string categoria = datos[1];
                double precio  = Convert.ToDouble(datos[2]);
                int calorias = Convert.ToInt32(datos[3]);
                bool esPicante = Convert.ToBoolean(datos[4]);
                Comida co = new Comida(nombre, categoria, precio, calorias, esPicante);
                comidas.Add(co);
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
            Console.WriteLine("1: Registro comida");
            Console.WriteLine("2: Visualizar todos los registros");
            Console.WriteLine("3: Eliminar registro");
            Console.WriteLine("4: Guardar cambios");
            Console.WriteLine("5: Ordenar");
            Console.WriteLine("0: Salir");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingresa el nombre de la comida:");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("Ingresa la categoría (ej. Mexicana, Italiana):");
                    string categoria = Console.ReadLine();

                    Console.WriteLine("Ingresa el precio:");
                    double precio = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingresa las calorías:");
                    int calorias = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("¿Es picante? (true/false):");
                    bool esPicante = Convert.ToBoolean(Console.ReadLine());

                    Comida comidaa = new Comida(nombre, categoria, precio, calorias, esPicante);

                    StreamWriter swr = new StreamWriter("registro_comidas.csv", true);
                    swr.WriteLine(comidaa.Nombre + "," + comidaa.Categoria + "," + comidaa.Precio + "," + comidaa.Calorias + "," + comidaa.EsPicante);
                    swr.Flush();
                    swr.Close();
                    
                    // Verificar si ya existe (por nombre)
                    bool existe = comidas.Any(c => c.Nombre == nombre);

                    if (existe)
                    {
                        Console.WriteLine("La comida ya está registrada");
                    }
                    else
                    {
                        Comida comida = new Comida(nombre, categoria, precio, calorias, esPicante);
                        comidas.Add(comida);
                    }
                    Console.WriteLine();
                    break;
                
                case 2:
                    Console.WriteLine("Lista de comidas registradas:");
                    foreach (Comida comida in comidas)
                    {
                        Console.WriteLine(comida);
                    }
                    Console.WriteLine();
                    break;
                
                case 3:
                    Console.WriteLine("Ingresa el nombre de la comida a eliminar:");
                    string nombreEliminar = Console.ReadLine();

                    Comida comidaEliminar = comidas.FirstOrDefault(c => c.Nombre == nombreEliminar);

                    if (comidaEliminar != null)
                    {
                        comidas.Remove(comidaEliminar);
                        Console.WriteLine("Registro eliminado");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró la comida");
                    }
                    Console.WriteLine();
                    break;
                
                case 4:
                    StreamWriter sw = new StreamWriter(ruta);

                    foreach (Comida comida in comidas)
                    {
                        sw.WriteLine(comida.Nombre + "," + comida.Categoria + "," + comida.Precio + "," + comida.Calorias + "," + comida.EsPicante);
                    }
                    sw.Close();
                    Console.WriteLine("Cambios guardados");
                    Console.WriteLine();
                    break;
                
                case 5:
                    comidas = comidas.OrderBy(c => c.Nombre).ToList();
                    Console.WriteLine("Registros ordenados por nombre");
                    Console.WriteLine();
                    break;
                
                case 0:
                    Console.WriteLine("gracias por usar el programa");
                    break;
            }
        } while (opcion != 0);
    }
}