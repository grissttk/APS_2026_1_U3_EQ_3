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
    public string Nombre { get => nombre; set => nombre = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int HorasSemanales { get => horasSemanales; set => horasSemanales = value; }
    public double CostoMensual { get => costoMensual; set => costoMensual = value; }
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