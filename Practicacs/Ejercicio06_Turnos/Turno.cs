// Cada turno tiene una fecha (representada como texto, por ejemplo "2025-06-15"), un horario (por ejemplo "10:30"), el nombre del cliente y el servicio solicitado (corte, tintura, etc.).
namespace Practicacs.Ejercicio06_Turnos;
public class Turno
{
    public string Fecha { get; set; }
    public string Horario { get; set; }
    public string NombreCliente { get; set; }
    public string Servicio { get; set; }

    public Turno(string fecha, string horario, string nombreCliente, string servicio)
    {
        Fecha = fecha;
        Horario = horario;
        NombreCliente = nombreCliente;
        Servicio = servicio;
    }
}
