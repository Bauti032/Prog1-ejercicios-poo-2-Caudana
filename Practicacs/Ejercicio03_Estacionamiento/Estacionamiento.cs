namespace Practicacs.Ejercicio03_Estacionamiento;
public class Estacionamiento
{
    public string Nombre {get;set;}
    public int CapMaxi {get;set;}
    public List<Vehiculo> vehiculos = new List<Vehiculo>();

    public Estacionamiento (string nombre, int capacidad)
    {
        Nombre = nombre;
        CapMaxi = capacidad;
        vehiculos = new List<Vehiculo>();
    }
}