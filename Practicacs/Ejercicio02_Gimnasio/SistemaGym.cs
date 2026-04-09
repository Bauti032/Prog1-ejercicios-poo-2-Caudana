namespace Practicacs.Ejericio02_Gimnasio;
public class SistemaGym
{
    public void AgregarSocio (Socio socio, Gimnasio gimnasio)
    {
        try {
            if (gimnasio.socios.Count() < gimnasio.Capmax) {
                gimnasio.socios.Add(socio);
                Console.WriteLine("Socio agregado con exito");
            } else
            {
                Console.WriteLine("La capacidad esta al maximo");
            }
            } catch (Exception ex)
        {
            Console.WriteLine($"Excepcion: {ex}");
        }
    }
    public void DarBaja (Socio socio, Gimnasio gimnasio)
    {
        gimnasio.socios.Remove(socio);
        Console.WriteLine("Socio Removido con exito");
    }
    public void MarcarCuota (Socio socio, string marca)
    {
        if (marca.ToLower() == "vencida")
        {
            Console.WriteLine($"{socio.Nombre} fue marcado con cuota vencida.");
            socio.Cuota = false;
        } else
        {
            socio.Cuota = true;
        }
    }
    public int CanDia (Gimnasio gimnasio)
    {
       int cantsoc = 0;

       foreach (var e in gimnasio.socios)
       {
            if (e.Cuota == true)
            {
                cantsoc ++;
            }
       }
       Console.WriteLine($"Cantidad de socios al día: {cantsoc}");
       return cantsoc;
    }
}