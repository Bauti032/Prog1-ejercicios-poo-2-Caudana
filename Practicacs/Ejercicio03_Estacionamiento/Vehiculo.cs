namespace Practicacs.Ejercicio03_Estacionamiento;
public class Vehiculo
{
    public string Ndueño {get;set;}
    public string Patente {get;set;}
    public bool Estacionado {get;set;}

    public Vehiculo (string nombre, string patente)
    {
        Ndueño = nombre;
        Patente = patente;
        Estacionado = false;
    }
}