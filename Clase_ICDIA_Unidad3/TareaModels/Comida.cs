namespace Clase_ICDIA_Unidad3.TareaModels;

public class Comida
{
    //atributos (5 características)
    private string nombre;
    private string categoria;
    private double precio;
    private int calorias;
    private bool esPicante;

    //propiedades
    public string Nombre { get => nombre; set => nombre = value; }
    public string Categoria { get => categoria; set => categoria = value; }
    public double Precio { get => precio; set => precio = value; }
    public int Calorias { get => calorias; set => calorias = value; }
    public bool EsPicante { get => esPicante; set => esPicante = value; }

    //constructor
    public Comida(string nombre, string categoria, double precio, int calorias, bool esPicante)
    {
        Nombre = nombre;
        Categoria = categoria;
        Precio = precio;
        Calorias = calorias;
        EsPicante = esPicante;
    }

    //toString
    public override string ToString()
    {
        return "(" + Nombre + ", " + Categoria + ", $" + Precio + ", " + Calorias + " kcal, Picante: " + EsPicante + ")";
    }
}