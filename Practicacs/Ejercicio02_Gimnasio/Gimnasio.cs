namespace Practicacs.Ejericio02_Gimnasio;
public class Gimnasio
{
    public string Nombre {get;set;}
    public int Capmax {get;set;}
    public List<Socio> socios = new List<Socio>();

    public Gimnasio (string nombre, int cap)
    {
        Nombre = nombre;
        Capmax = cap;
        socios = new List<Socio>();
    }

}