// El sistema debe permitir asignar un turno a un peluquero específico, cancelar un turno, listar todos los turnos de un peluquero para una fecha dada y verificar si un peluquero tiene disponibilidad en un horario determinado.

namespace Practicacs.Ejercicio06_Turnos;
public class SistTurno
{
    private List<Peluquero> peluqueros = new List<Peluquero>();

    public void AgregarPeluquero(Peluquero peluquero)
    {
        peluqueros.Add(peluquero);
    }

    public void AsignarTurno(Peluquero peluquero, Turno turno)
    {
        if (peluquero.Agenda.Any(t => t.Fecha == turno.Fecha && t.Horario == turno.Horario))
        {
            Console.WriteLine("El peluquero no tiene disponibilidad en ese horario.");
        }
        else
        {
            peluquero.Agenda.Add(turno);
            Console.WriteLine("Turno asignado correctamente.");
        }
    }

    public void CancelarTurno(Peluquero peluquero, Turno turno)
    {
        if (peluquero.Agenda.Remove(turno))
        {
            Console.WriteLine("Turno cancelado correctamente.");
        }
        else
        {
            Console.WriteLine("El turno no se encontró en la agenda del peluquero.");
        }
    }

    public void ListarTurnos(Peluquero peluquero, string fecha)
    {
        var turnos = peluquero.Agenda.Where(t => t.Fecha == fecha).ToList();
        if (turnos.Count > 0)
        {
            Console.WriteLine($"Turnos de {peluquero.Nombre} para el {fecha}:");
            foreach (var turno in turnos)
            {
                Console.WriteLine($"Horario: {turno.Horario}, Cliente: {turno.NombreCliente}, Servicio: {turno.Servicio}");
            }
        }
        else
        {
            Console.WriteLine($"No hay turnos para {peluquero.Nombre} en la fecha {fecha}.");
        }
    }

    public bool VerificarDisponibilidad(Peluquero peluquero, string fecha, string horario)
    {
        return !peluquero.Agenda.Any(t => t.Fecha == fecha && t.Horario == horario);
    }
}