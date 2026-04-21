namespace Clase_ICDIA_Unidad3.Models;

public class Alumno : IComparable<Alumno>
{
    //Atributos
    private long matricula;
    private string nombre;
    
    //Propiedades
    public long Matricula
    {
        get => matricula; 
        set => matricula = value;
    }
    public string Nombre
    {
        get => nombre; 
        set => nombre = value;
    }
    
    //Constructor
    public Alumno(long matricula, string nombre)
    {
        Matricula = matricula;
        Nombre = nombre;
    }

    public Alumno(long matricula)
    {
        Matricula = matricula;
    }
    
    //ToString
    public int CompareTo(Alumno? other)
    {
        return //this.Matricula-other.Matricula;
            this.Matricula.CompareTo(other.Matricula);
    }

    public override string ToString()
    {
        return "(" + Matricula.ToString() + ") - " + Nombre;
    }
}