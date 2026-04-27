using Clase_ICDIA_Unidad3.TareaModels;

namespace Clase_ICDIA_Unidad3.TareaRunners;

public class RunnerT02_Mascotas
{
    public RunnerT02_Mascotas()
    {
        string ruta = "registro_Mascotas.csv";
        List<Mascotas> mascotas = new List<Mascotas>();
        
        if (File.Exists(ruta))
        {
            foreach (string linea in File.ReadLines(ruta))
            {
                string[] datos = linea.Split(',');
                string nombre = datos[0];
                string especie = datos[1];
                string raza  = datos[2];
                int edad = Convert.ToInt32(datos[3]);
                double peso= Convert.ToDouble(datos[4]);
                Mascotas mas = new Mascotas(nombre, especie, raza, edad, peso);
                mascotas.Add(mas);
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
            Console.WriteLine("1: registro mascota");
            Console.WriteLine("2: Visualizar todos los registros");
            Console.WriteLine("3: Eliminar registro");
            Console.WriteLine("4: Guardar cambios");
            Console.WriteLine("5: Ordenar");
            Console.WriteLine("0: salir");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("ingresa el nombre de la mascota");
                    string nombre = Console.ReadLine();
                    
                    Console.WriteLine("ingresa la especie (ej. Perro, Gato)");
                    string especie = Console.ReadLine();
                    
                    Console.WriteLine("ingresa la raza");
                    string raza = Console.ReadLine();
                    
                    Console.WriteLine("ingresa la edad");
                    int edad = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("ingresa el peso en kg");
                    double peso = Convert.ToDouble(Console.ReadLine());

                    Mascotas mascotaa = new Mascotas(nombre, especie, raza, edad, peso);

                    //guardar mascota
                    StreamWriter sw = new StreamWriter("registro_mascotas.csv", true);
                    sw.WriteLine(mascotaa.Nombre + "," + mascotaa.Especie + "," + mascotaa.Raza + "," + mascotaa.Edad + "," + mascotaa.Peso);
                    sw.Flush();
                    sw.Close();
                    
                    // Verificar si ya existe (por nombre)
                    bool existe = mascotas.Any(c => c.Nombre == nombre);

                    if (existe)
                    {
                        Console.WriteLine("La comida ya está registrada");
                    }
                    else
                    {
                        Mascotas mascota = new Mascotas(nombre,especie, raza, edad, peso);
                        mascotas.Add(mascota);
                    }
                    Console.WriteLine();
                    break;
                
                case 2:
                    Console.WriteLine("Lista de mascotas registradas:");
                    foreach (Mascotas mascota in mascotas)
                    {
                        Console.WriteLine(mascota);
                    }
                    Console.WriteLine();
                    break;
                
                case 3:
                    Console.WriteLine("Ingresa el nombre de la mascota a eliminar:");
                    string nombreEliminar = Console.ReadLine();

                    Mascotas mascotaEliminar = mascotas.FirstOrDefault(c => c.Nombre == nombreEliminar);

                    if (mascotaEliminar != null)
                    {
                        mascotas.Remove(mascotaEliminar);
                        Console.WriteLine("Registro eliminado");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró la mascota");
                    }
                    Console.WriteLine();
                    break;
                
                case 4:
                    StreamWriter swr = new StreamWriter(ruta);

                    foreach (Mascotas mascota in mascotas)
                    {
                        swr.WriteLine(mascota.Nombre + "," + mascota.Especie + "," + mascota.Raza + "," + mascota.Edad + "," + mascota.Peso);
                    }
                    swr.Close();
                    Console.WriteLine("Cambios guardados");
                    Console.WriteLine();
                    break;
                
                case 5:
                    mascotas = mascotas.OrderBy(c => c.Nombre).ToList();
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