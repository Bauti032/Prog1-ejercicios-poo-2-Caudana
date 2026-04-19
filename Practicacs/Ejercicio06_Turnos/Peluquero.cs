// Una peluquería necesita organizar su agenda de turnos. Cada turno tiene una fecha (representada como texto, por ejemplo "2025-06-15"), un horario (por ejemplo "10:30"), el nombre del cliente y el servicio solicitado (corte, tintura, etc.). La peluquería puede tener varios peluqueros, cada uno con su propia agenda. El sistema debe permitir asignar un turno a un peluquero específico, cancelar un turno, listar todos los turnos de un peluquero para una fecha dada y verificar si un peluquero tiene disponibilidad en un horario determinado.
namespace Practicacs.Ejercicio06_Turnos;
public class Peluquero
{
    public string Nombre { get; set; }
    public List<Turno> Agenda { get; set; }

    public Peluquero(string nombre)
    {
        Nombre = nombre;
        Agenda = new List<Turno>();
    }
}