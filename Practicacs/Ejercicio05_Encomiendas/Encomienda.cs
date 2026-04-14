namespace Practicacs.Ejercicio05_Encomienda;
public class Encomienda
{
    public string Codigo { get; set; }
    public string NomRemitente { get; set; }  
    public string NomDestinatario { get; set; }
    public string Estado { get; set; }

    public Encomienda(string codigo, string nomRemitente, string nomDestinatario)
    {
        Codigo = codigo;
        NomRemitente = nomRemitente;
        NomDestinatario = nomDestinatario;
        Estado = "Ingresada";
    }
    
}