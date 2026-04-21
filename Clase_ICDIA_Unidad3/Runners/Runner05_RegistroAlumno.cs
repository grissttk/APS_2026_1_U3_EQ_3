using Clase_ICDIA_Unidad3.Models;

namespace Clase_ICDIA_Unidad3.Runners;

public class Runner05_RegistroAlumno
{
    public Runner05_RegistroAlumno()
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
            Console.WriteLine("4. Guardar cambios");
            Console.WriteLine("5. Ordenar por Matricula");
            Console.WriteLine("0. Salir");
            opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            long matricula;
            string nombre;
            
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingresa el nombre del Alumno:");
                    nombre = Console.ReadLine();
                    Console.WriteLine();
                    
                    Console.WriteLine("Ingresa la matricula del Alumno:");
                    matricula = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine();
                    
                    //Verifica si la matricula ya existe
                    bool existe = alumnos.Any(a => a.Matricula == matricula);
                    
                    if (existe)
                    {
                        Console.WriteLine("La matrícula ya existe");
                    }
                    else
                    {
                        Alumno al = new Alumno(matricula, nombre);
                        alumnos.Add(al);
                    }
                    Console.WriteLine();
                    //Guardar alumno!!
                    break;
                
                case 2: 
                    Console.WriteLine("Lista de registros almacenados:");
                    foreach (Alumno alumno in alumnos)
                    {
                        Console.WriteLine(alumno);
                    }
                    Console.WriteLine();
                    break;
                
                case 3:
                    Console.WriteLine("Ingresa la matricula del registro a eliminar:");
                    matricula = Convert.ToInt64(Console.ReadLine());
                    bool resultado =  alumnos.Contains(new Alumno(matricula));
                    //Console.WriteLine(resultado);
                    if (resultado)
                    {
                        alumnos.Remove(new Alumno(matricula));
                    }
                    Console.WriteLine();
                    break;
                
                case 4: //Guardar cambios
                    StreamWriter sw = new StreamWriter(ruta);

                    for (int i = 0; i < alumnos.Count; i++)
                    {
                        Alumno alumno = alumnos[i];
                        sw.WriteLine(alumno.Matricula + "," + alumno.Nombre);
                    }
                    sw.Close();
                    Console.WriteLine();
                    break;
                
                case 5: //Ordenar por Matricula
                    alumnos = alumnos.OrderBy(a => a.Matricula).ToList();
                    break;
                
                case 0:
                    Console.WriteLine("Gracias por usar nuestro programa!!");
                    break;
            }
        } while (opcion != 0);
    }
}