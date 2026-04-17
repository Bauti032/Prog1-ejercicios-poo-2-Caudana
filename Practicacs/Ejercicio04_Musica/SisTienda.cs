namespace Practicacs.Ejercicio04_Musica;
public class SisTienda
{
    public List<Instrumento> Inventario { get; set; }
    public SisTienda()
    {
        Inventario = new List<Instrumento>();
    }
    public void AgregarInstrumento(Instrumento instrumento)
    {
        try
        {
            Inventario.Add(instrumento);
            Console.WriteLine($"Instrumento {instrumento.Nombre} agregado al inventario.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al agregar instrumento: {ex.Message}");
        }
    }
    public void RegistrarVenta(string nombreInstrumento)
    {
        var instrumento = Inventario.FirstOrDefault(i => i.Nombre == nombreInstrumento);
        if (instrumento != null)
        {
            Inventario.Remove(instrumento);
        }
    }
    public List<Instrumento> BuscarPorCategoria(string categoria)
    {
        return Inventario.Where(i => i.Categoria == categoria).ToList();
    }
    public double CalcularValorTotalInventario()
    {
        return Inventario.Sum(i => i.Precio);
    }

}