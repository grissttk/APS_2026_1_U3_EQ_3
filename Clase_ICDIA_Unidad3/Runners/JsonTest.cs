using System.Text.Json;
using Clase_ICDIA_Unidad3.Models;

namespace Clase_ICDIA_Unidad3.Runners;

public class JsonTest
{
    public JsonTest()
    {
        Alumno alumno = new Alumno(56, "Gato");
        alumno.Calificacion = 10;
        Console.WriteLine(alumno);
        
        Console.WriteLine();
        string alumno_json = JsonSerializer.Serialize(alumno);
        Console.WriteLine(alumno_json);
        
        Console.WriteLine();
        Alumno alumnoTemp = JsonSerializer.Deserialize<Alumno>(alumno_json);
        Console.WriteLine(alumnoTemp);
    }
}