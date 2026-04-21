namespace Clase_ICDIA_Unidad3.TareaModels;

public class Musica
{
    //atributos (5 características)
    private string titulo;
    private string artista;
    private string genero;
    private int anioLanzamiento;
    private double duracionMinutos;

    //propiedades
    public string Titulo { get => titulo; set => titulo = value; }
    public string Artista { get => artista; set => artista = value; }
    public string Genero { get => genero; set => genero = value; }
    public int AnioLanzamiento { get => anioLanzamiento; set => anioLanzamiento = value; }
    public double DuracionMinutos { get => duracionMinutos; set => duracionMinutos = value; }

    //constructor
    public Musica(string titulo, string artista, string genero, int anioLanzamiento, double duracionMinutos)
    {
        Titulo = titulo;
        Artista = artista;
        Genero = genero;
        AnioLanzamiento = anioLanzamiento;
        DuracionMinutos = duracionMinutos;
    }

    //toString
    public override string ToString()
    {
        return "(" + Titulo + ", " + Artista + ", " + Genero + ", " + AnioLanzamiento + ", " + DuracionMinutos + " min)";
    }
}