namespace Clase_ICDIA_Unidad3.TareaModels;

public class Deporte
{
    //atributos (5 características)
    private string nombre;
    private string tipo; // e.g., Equipo, Individual
    private int numeroJugadores;
    private bool esOlimpico;
    private double duracionPromedioMinutos;

    //propiedades
    public string Nombre
    {
        get => nombre;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new NombreDeporteException("El nombre del deporte no puede estar vacío");

            if (value.Length > 100)
                throw new NombreDeporteException("El nombre del deporte es demasiado largo");

            nombre = value;
        }
    }

    public string Tipo
    {
        get => tipo;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El tipo no puede estar vacío");

            tipo = value;
        }
    }

    public int NumeroJugadores
    {
        get => numeroJugadores;
        set
        {
            if (value <= 0)
                throw new NumeroJugadoresException("El número de jugadores debe ser mayor a 0");

            numeroJugadores = value;
        }
    }
    public bool EsOlimpico { get => esOlimpico; set => esOlimpico = value; }

    public double DuracionPromedioMinutos
    {
        get => duracionPromedioMinutos;
        set
        {
            if (value <= 0)
                throw new DuracionException("La duración debe ser mayor a 0 minutos");

            duracionPromedioMinutos = value;
        }
    }

    //constructor
    public Deporte(string nombre, string tipo, int numeroJugadores, bool esOlimpico, double duracionPromedioMinutos)
    {
        Nombre = nombre;
        Tipo = tipo;
        NumeroJugadores = numeroJugadores;
        EsOlimpico = esOlimpico;
        DuracionPromedioMinutos = duracionPromedioMinutos;
    }

    //toString
    public override string ToString()
    {
        return "(" + Nombre + ", " + Tipo + ", " + NumeroJugadores + " jugadores, Olímpico: " + EsOlimpico + ", " + DuracionPromedioMinutos + " min)";
    }
}