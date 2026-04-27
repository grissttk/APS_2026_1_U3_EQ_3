namespace Clase_ICDIA_Unidad3.TareaModels;

public class Pasatiempo
{
    //atributos (5 características)
    private string nombre;
    private string descripcion;
    private int horasSemanales;
    private double costoMensual;
    private bool requiereEquipo;

    //propiedades
    public string Nombre
    {
        get => nombre;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new NombrePasatiempoException("El nombre no puede estar vacío");

            if (value.Length > 100)
                throw new NombrePasatiempoException("El nombre es demasiado largo");

            nombre = value;
        }
    }

    public string Descripcion
    {
        get => descripcion;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new DescripcionException("La descripción no puede estar vacía");

            if (value.Length > 200)
                throw new DescripcionException("La descripción es demasiado larga");

            descripcion = value;
        }
    }

    public int HorasSemanales
    {
        get => horasSemanales;
        set
        {
            if (value <= 0)
                throw new HorasException("Las horas deben ser mayores a 0");

            if (value > 168) // 24*7
                throw new HorasException("Las horas exceden el total de la semana");

            horasSemanales = value;
        }
    }

    public double CostoMensual
    {
        get => costoMensual;
        set
        {
            if (value < 0)
                throw new CostoException("El costo no puede ser negativo");

            if (value > 100000)
                throw new CostoException("Costo fuera de rango lógico");

            costoMensual = value;
        }
    }
    public bool RequiereEquipo { get => requiereEquipo; set => requiereEquipo = value; }

    //constructor
    public Pasatiempo(string nombre, string descripcion, int horasSemanales, double costoMensual, bool requiereEquipo)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        HorasSemanales = horasSemanales;
        CostoMensual = costoMensual;
        RequiereEquipo = requiereEquipo;
    }

    //toString
    public override string ToString()
    {
        return "(" + Nombre + ", " + Descripcion + ", " + HorasSemanales + " hrs/sem, $" + CostoMensual + ", Equipo requerido: " + RequiereEquipo + ")";
    }
}