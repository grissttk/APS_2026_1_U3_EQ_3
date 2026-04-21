namespace Clase_ICDIA_Unidad3.TareaModels;

public class Mascotas
{
    //atributos (5 características)
    private string nombre;
    private string especie;
    private string raza;
    private int edad;
    private double peso;

    //propiedades
    public string Nombre { get => nombre; set => nombre = value; }
    public string Especie { get => especie; set => especie = value; }
    public string Raza { get => raza; set => raza = value; }
    public int Edad { get => edad; set => edad = value; }
    public double Peso { get => peso; set => peso = value; }

    //constructor
    public Mascotas(string nombre, string especie, string raza, int edad, double peso)
    {
        Nombre = nombre;
        Especie = especie;
        Raza = raza;
        Edad = edad;
        Peso = peso;
    }

    //toString
    public override string ToString()
    {
        return "(" + Nombre + ", " + Especie + ", " + Raza + ", " + Edad + " años, " + Peso + " kg)";
    }
}