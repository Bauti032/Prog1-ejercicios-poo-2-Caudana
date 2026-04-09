namespace Practicacs.Ejercicio01_Veterinaria;

public class Animal
{
    public string Nombre {get;set;}
    public string Especie {get;set;}
    public int Edad {get;set;}
    public bool Activo {get;set;}

    public Animal (string nombre, string especie, int edad)
    {
        Nombre = nombre;
        Especie = especie;
        Edad = edad;
        Activo = false;
    }
}