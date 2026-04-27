using Clase_ICDIA_Unidad3.TareaModels;

namespace Clase_ICDIA_Unidad3.TareaRunners;

public class RunnerT04_Pasatiempos
{
    public RunnerT04_Pasatiempos()
    {
        string ruta = "registro_Pasatiempos.csv";
        List<Pasatiempo> pasatiempos = new List<Pasatiempo>();
        
        if (File.Exists(ruta))
        {
            foreach (string linea in File.ReadLines(ruta))
            {
                string[] datos = linea.Split(',');
                string nombre = datos[0];
                string descripcion = datos[1];
                int horasSemanales  = Convert.ToInt32(datos[2]);
                double costoMensual = Convert.ToDouble(datos[3]);
                bool requiereEquipo = Convert.ToBoolean(datos[4]);
                Pasatiempo pa = new Pasatiempo(nombre, descripcion, horasSemanales, costoMensual, requiereEquipo);
                pasatiempos.Add(pa);
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
            Console.WriteLine("1: registro pasatiempo");
            Console.WriteLine("2: Visualizar todos los registros");
            Console.WriteLine("3: Eliminar registro");
            Console.WriteLine("4: Guardar cambios");
            Console.WriteLine("5: Ordenar");
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
                    
                    // Verificar si ya existe (por nombre)
                    bool existe = pasatiempos.Any(c => c.Nombre == nombre);

                    if (existe)
                    {
                        Console.WriteLine("El pasatiempo ya está registrado");
                    }
                    else
                    {
                        Pasatiempo pasatiempo = new Pasatiempo(nombre, descripcion, horas, costo, equipo);
                        pasatiempos.Add(pasatiempo);
                    }
                    Console.WriteLine();
                    break;
                
                case 2:
                    Console.WriteLine("Lista de pasatiempos registrados:");
                    foreach (Pasatiempo pasatiempo in pasatiempos)
                    {
                        Console.WriteLine(pasatiempo);
                    }
                    Console.WriteLine();
                    break;
                
                case 3:
                    Console.WriteLine("Ingresa el nombre del pasatiempo a eliminar:");
                    string nombreEliminar = Console.ReadLine();

                    Pasatiempo pasatiempoEliminar = pasatiempos.FirstOrDefault(c => c.Nombre == nombreEliminar);

                    if (pasatiempoEliminar != null)
                    {
                        pasatiempos.Remove(pasatiempoEliminar);
                        Console.WriteLine("Registro eliminado");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró el pasatiempo");
                    }
                    Console.WriteLine();
                    break;
                
                case 4:
                    StreamWriter swr = new StreamWriter(ruta);

                    foreach (Pasatiempo pasatiempo in pasatiempos)
                    {
                        swr.WriteLine(pasatiempo.Nombre + "," + pasatiempo.Descripcion + "," + pasatiempo.HorasSemanales + "," +
                                      pasatiempo.CostoMensual + "," + pasatiempo.RequiereEquipo);
                    }
                    swr.Close();
                    Console.WriteLine("Cambios guardados");
                    Console.WriteLine();
                    break;
                
                case 5:
                    pasatiempos = pasatiempos.OrderBy(c => c.Nombre).ToList();
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