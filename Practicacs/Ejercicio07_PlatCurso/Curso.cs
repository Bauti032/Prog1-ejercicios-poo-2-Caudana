namespace Practicacs.Ejercicio07_PlatCurso;
public class Curso
{
    public string Titulo {get;set;}
    public string Descripcion {get;set;}
    public int Duracion {get;set;}
    public int Max_Cupo {get;set;}
    public List<Alumno> alumnos {get;set;}

    public Curso (string titulo, string desc, int duracionhs, int cup_max)
    {
        Titulo = titulo;
        Descripcion = desc;
        Duracion = duracionhs;
        Max_Cupo = cup_max;
        alumnos = new List<Alumno>();
        
    }
}