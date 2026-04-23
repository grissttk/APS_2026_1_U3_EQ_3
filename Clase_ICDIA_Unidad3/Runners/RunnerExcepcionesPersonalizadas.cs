using Clase_ICDIA_Unidad3.Models;

namespace Clase_ICDIA_Unidad3.Runners;

public class RunnerExcepcionesPersonalizadas
{
    public RunnerExcepcionesPersonalizadas()
    {
        try
        {
            Alumno al = new Alumno();
            long matricula = 1000;
            al.Matricula = matricula;

            int edad = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(al);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (MatriculaException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}