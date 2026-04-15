namespace Clase_ICDIA_Unidad3.Models;

public class Alumno
{
    //Atributos
    private long matricula;
    private string nombre;
    
    //Propiedades
    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }
    
    public long Matricula
    {
        get => matricula;
        set => matricula = value;
    }
    
    //Constructor
    public Alumno(long matricula, string nombre)
    {
        Matricula = matricula;
        Nombre = nombre;
    }
    
    //ToString
    public override string ToString()
    {
        return "(" + Matricula.ToString() + ") - " + Nombre;
    }
}