namespace Practicacs.Ejercicio07_PlatCurso;


public class Alumno
{
    public string Nombre {get;set;}
    public string Email {get;set;}
    public List<Curso> cursos {get;set;} 


    public Alumno (string nom, string email)
    {
        Nombre = nom;
        Email = email;
        cursos = new List<Curso>();
    }    
    
}