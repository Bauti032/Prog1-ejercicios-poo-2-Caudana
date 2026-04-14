namespace Practicacs.Ejercicio04_Musica;

public class Instrumento
{
    public string Nombre {get;set;} 
    public string Categoria {get;set;}
    public double Precio {get;set;}

    public Instrumento(string nombre, string categoria, double precio)
    {
        Nombre = nombre;
        Categoria = categoria;
        Precio = precio;
    }
}