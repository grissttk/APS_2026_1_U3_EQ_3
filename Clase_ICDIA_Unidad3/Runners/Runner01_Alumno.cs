using Clase_ICDIA_Unidad3.Models;

namespace Clase_ICDIA_Unidad3.Runners;

public class Runner01_Alumno
{
    public Runner01_Alumno()
    {
        Alumno al1 = new Alumno(1, "Juan Perez");
        Alumno al2 = new Alumno(2, "Juan Sanchez");
        Alumno al3 = new Alumno(3, "Juan Pablo");
        
        StreamWriter sw = new StreamWriter("Alumnos.txt");
        
        sw.WriteLine(al1.Matricula + "," + al1.Nombre);
        sw.WriteLine(al2.Matricula + "," + al2.Nombre);
        sw.WriteLine(al3.Matricula + "," + al3.Nombre);
        
        sw.Flush();
        sw.Close();
    }
}