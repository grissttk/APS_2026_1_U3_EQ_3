using Clase_ICDIA_Unidad3.Models;

namespace Clase_ICDIA_Unidad3.Runners;

public class Runner02_RegistroAlumnos
{
    public Runner02_RegistroAlumnos()
    {

        int alumnos_registrados = 0;
        int opcion = 0;
        do
        {
            Console.WriteLine("Ingresa el número de la acción deseada");
            Console.WriteLine("1. Registro Alumno");
            Console.WriteLine("0. Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingresa el nombre del Alumno:");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa la matricula del Alumno:");
                    long matricula = Convert.ToInt64(Console.ReadLine());
                    Alumno al = new Alumno(matricula, nombre);
                    //Guardar alumno!!
                    StreamWriter sw = new StreamWriter("registro.csv", true);
                    sw.WriteLine(al.Matricula + "," + al.Nombre);
                    sw.Flush();
                    sw.Close();
                    break;
                case 0:
                    Console.WriteLine("Gracias por usuar nuestro programa!!");
                    break;
            }
            
        } while (opcion != 0);

    }
}

// 5 cosas por cada registro
//Programa que elabore un registro de comidas
// Mascotas
// Lo que sea
// Pasatiempos
// Videojuegos o Deportes