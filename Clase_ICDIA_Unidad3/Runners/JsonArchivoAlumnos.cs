using System.Text.Json;
using Clase_ICDIA_Unidad3.Models;

namespace Clase_ICDIA_Unidad3.Runners;

public class JsonArchivoAlumnos
{
    public JsonArchivoAlumnos()
    {
        Alumno al1;
        Alumno al2;
        Alumno al3;

        Random random;
        StreamReader sr;
        StreamWriter sw;
        
        //De clases statics no se puede generar objetos
        //JsonSerializer serializer;
        //Math math;
        
        al1 = new Alumno(1, "Root", 5);
        al2 = new Alumno(2, "Pepe", 7);
        al3 = new Alumno(3, "Morris", 9);
        
        sw = new StreamWriter("Alumnos.json");
        
        string json = JsonSerializer.Serialize(al1);
        sw.WriteLine(json);
        
        json = JsonSerializer.Serialize(al2);
        sw.WriteLine(json);
        
        json = JsonSerializer.Serialize(al3);
        sw.WriteLine(json);
        
        sw.Flush();
        sw.Close();
    }
}