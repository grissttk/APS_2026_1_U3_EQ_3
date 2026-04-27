namespace Clase_ICDIA_Unidad3.Models;

public abstract class Poligono
{
    private string Nombre;

    public int CalcularPerimetro(int lados, int longitud)
    {
        return lados * longitud;
    }

    public abstract int CalcularArea(int[] parametros);
}