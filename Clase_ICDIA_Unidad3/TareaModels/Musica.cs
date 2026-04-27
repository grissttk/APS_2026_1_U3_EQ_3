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
    public string Titulo
    {
        get => titulo;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new TituloException("El título no puede estar vacío");

            if (value.Length > 150)
                throw new TituloException("El título es demasiado largo");

            titulo = value;
        }
    }

    public string Artista
    {
        get => artista;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArtistaException("El artista no puede estar vacío");

            if (value.Length > 100)
                throw new ArtistaException("El nombre del artista es demasiado largo");

            artista = value;
        }
    }

    public string Genero
    {
        get => genero;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El género no puede estar vacío");

            genero = value;
        }
    }

    public int AnioLanzamiento
    {
        get => anioLanzamiento;
        set
        {
            int anioActual = DateTime.Now.Year;

            if (value < 1900 || value > anioActual)
                throw new AnioException("El año de lanzamiento no es válido");

            anioLanzamiento = value;
        }
    }

    public double DuracionMinutos
    {
        get => duracionMinutos;
        set
        {
            if (value <= 0)
                throw new DuracionMusicaException("La duración debe ser mayor a 0");

            if (value > 60)
                throw new DuracionMusicaException("Duración poco realista (No puede ser mayor a 60 min)");

            duracionMinutos = value;
        }
    }

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