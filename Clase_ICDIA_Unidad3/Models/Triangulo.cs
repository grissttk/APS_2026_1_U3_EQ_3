namespace Clase_ICDIA_Unidad3.Models;

public class Triangulo : Poligono
{
    public override int CalcularArea(int[] parametros)
    {
        if (parametros.Length < 2)
        {
            throw new ArgumentException("Se ocupan dos parametros");
        }
        return parametros[0] * parametros[1];
    }
    
}