namespace Practicacs.Ejercicio05_Encomienda;
public class SistEncomienda
{
    private List<Encomienda> encomiendas = new List<Encomienda>();
    public void AgregarEncomienda(Encomienda encomienda)
    {
        encomiendas.Add(encomienda);
    }
    public void AvanzarEncomienda(Encomienda encomienda)
    {
        if (encomienda.Estado == "Ingresada")
        {
            encomienda.Estado = "En camino";
        } else
        {
            encomienda.Estado = "Entregada";
        }
    }
    public void AveriguarEncomienda(Encomienda encomienda)
    {
       Console.WriteLine($"El estado es: {encomienda.Estado}"); 
    }
    // listar todas las encomiendas que todavía no fueron entregadas.
    public void ListarEncomiendas()
    {
        foreach (var encomienda in encomiendas)
        {
            if (encomienda.Estado != "Entregada")
            {
                Console.WriteLine($"Codigo: {encomienda.Codigo}, Remitente: {encomienda.NomRemitente}, Destinatario: {encomienda.NomDestinatario}, Estado: {encomienda.Estado}");
            }
        }
    }
}