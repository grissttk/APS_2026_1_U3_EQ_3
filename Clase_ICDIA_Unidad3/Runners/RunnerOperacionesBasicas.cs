using Clase_ICDIA_Unidad3.Utilidades;

namespace Clase_ICDIA_Unidad3.Runners;

public class RunnerOperacionesBasicas
{
    public RunnerOperacionesBasicas()
    {
        //Math.PI
        
        //int resultado = OperacionesBasicas.Suma(2, 4);
        int resultado = OperacionesBasicas.Multiplicacion(2, 4);
        
        double indiceR = OperacionesBasicas.INDICE_REPROBACION;
        
        Console.WriteLine($"Resultado: {resultado}");

    }
}