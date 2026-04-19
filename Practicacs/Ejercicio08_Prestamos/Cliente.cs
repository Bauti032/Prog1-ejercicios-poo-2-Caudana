namespace Practicacs.Ejerciocio08_Prestamos;
public class Cliente 
{
    public string Nombre {get;set;} 
    public string CUIT {get;set;}
    public List<Prestamo> prestamos {get;set;} = new List<Prestamo>();

    public Cliente (string nombre, string cuit )
    {
        Nombre = nombre;
        CUIT = cuit;
        prestamos = new List<Prestamo>();
    }

}   