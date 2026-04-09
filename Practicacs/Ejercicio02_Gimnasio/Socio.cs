namespace Practicacs.Ejericio02_Gimnasio;
public class Socio
{
    public string Nombre {get;set;}
    public int Nrosocio {get;set;}
    public bool Cuota {get;set;}

    public Socio (string nombre, int nro)
    {
        Nombre = nombre;
        Nrosocio = nro;
        Cuota = true;
    }
}