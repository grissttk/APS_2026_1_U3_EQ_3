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
    public string Nombre { get => nombre; set => nombre = value; }
    public string Tipo { get => tipo; set => tipo = value; }
    public int NumeroJugadores { get => numeroJugadores; set => numeroJugadores = value; }
    public bool EsOlimpico { get => esOlimpico; set => esOlimpico = value; }
    public double DuracionPromedioMinutos { get => duracionPromedioMinutos; set => duracionPromedioMinutos = value; }

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