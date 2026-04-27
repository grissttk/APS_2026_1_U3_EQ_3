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
    public string Nombre
    {
        get => nombre;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new NombreMascotaException("El nombre no puede estar vacío");

            if (value.Length > 100)
                throw new NombreMascotaException("El nombre es demasiado largo");

            nombre = value;
        }
    }

    public string Especie
    {
        get => especie;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new EspecieException("La especie no puede estar vacía");

            especie = value;
        }
    }

    public string Raza
    {
        get => raza;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("La raza no puede estar vacía");

            raza = value;
        }
    }

    public int Edad
    {
        get => edad;
        set
        {
            if (value < 0)
                throw new EdadException("La edad no puede ser negativa");

            if (value > 100)
                throw new EdadException("Edad fuera de rango lógico");

            edad = value;
        }
    }

    public double Peso
    {
        get => peso;
        set
        {
            if (value <= 0)
                throw new PesoException("El peso debe ser mayor a 0");

            if (value > 500)
                throw new PesoException("Peso fuera de rango lógico");

            peso = value;
        }
    }

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