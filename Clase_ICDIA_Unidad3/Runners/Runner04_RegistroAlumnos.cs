using Clase_ICDIA_Unidad3.Models;

namespace Clase_ICDIA_Unidad3.Runners;

public class Runner04_RegistroAlumnos
{
    public Runner04_RegistroAlumnos()
    {
        string ruta = "registro.csv";
        List<Alumno> alumnos = new List<Alumno>();
        //Cargar el registro actualizado...
        if (File.Exists(ruta)) //Si el archivo existe
        {
            //Cargamos el archivo
            foreach (string linea in File.ReadLines(ruta)){
                //Console.WriteLine(linea);
                string[] datos = linea.Split(',');
                long matricula = Convert.ToInt64(datos[0]);
                string nombre = datos[1];
                Alumno al = new Alumno(matricula, nombre);
                alumnos.Add(al);
            }
        }
        else
        {
            Console.WriteLine("No existen registro previos");
        }

        int alumnos_registrados = alumnos.Count;
        int opcion = 0;
        do
        {
            Console.WriteLine("Ingresa el número de la acción deseada");
            Console.WriteLine("1. Registro Alumno");
            Console.WriteLine("2. Visualizar todos los registros");
            Console.WriteLine("3. Eliminación de registros");
            Console.WriteLine("0. Salir");
            opcion = Convert.ToInt32(Console.ReadLine());

            long matricula;
            string nombre;
            
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingresa el nombre del Alumno:");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa la matricula del Alumno:");
                    matricula = Convert.ToInt64(Console.ReadLine());
                    Alumno al = new Alumno(matricula, nombre);
                    //Guardar alumno!!
                    StreamWriter sw = new StreamWriter(ruta, true);
                    sw.WriteLine(al.Matricula + "," + al.Nombre);
                    sw.Flush();
                    sw.Close();
                    break;
                
                case 2: 
                    Console.WriteLine("Lista de registros almacenados:");
                    foreach (Alumno alumno in alumnos)
                    {
                        Console.WriteLine(alumno);
                    }
                    break;
                
                case 3:
                    Console.WriteLine("Ingresa la matricula del registro a eliminar:");
                    matricula = Convert.ToInt64(Console.ReadLine());
                    bool resultado =  alumnos.Contains(new Alumno(matricula));
                    Console.WriteLine(resultado);
                    break;
                
                case 0:
                    Console.WriteLine("Gracias por usar nuestro programa!!");
                    break;
            }
            
        } while (opcion != 0);
    }
}