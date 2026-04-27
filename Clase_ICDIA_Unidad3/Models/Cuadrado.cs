namespace Clase_ICDIA_Unidad3.Models;

public class Cuadrado : Poligono
{
    public override int CalcularArea(int[] parametros)
    {
        if (parametros.Length < 1)
        {
            throw new Exception("La parametro debe estar entre 1 e 10");
        }
        return parametros[0] * parametros[0];
    }
}