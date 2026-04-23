namespace Clase_ICDIA_Unidad3.Models;

public class MatriculaException : Exception
{
    public MatriculaException(string mensaje) 
        : base(mensaje)
    {
        //Guardar el base de datos que ocurrio este error
    }
}