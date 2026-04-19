namespace Practicacs.Ejercicio07_PlatCurso;
public class Sistemacurso
{
    public void AgregarAlumno (Curso curso, Alumno alumno)
    {
        bool cupo = true;
        string nom_curso = curso.Titulo;
        bool inscripto = false;
        foreach (var p in alumno.cursos)
        {
            if (p.Titulo == nom_curso)
            {
                inscripto = true;
            }
        }
        if (curso.alumnos.Count() > curso.Max_Cupo)
        {
            cupo = false;
        }
        try {
        if (cupo == true && inscripto == false)
        {
            alumno.cursos.Add(curso);
            curso.alumnos.Add(alumno);
            Console.WriteLine($"Alumno Inscripto. Cupo restante en el curso {curso.Max_Cupo - curso.alumnos.Count()}");
        } else
            {
                Console.WriteLine("El alumno ya esta inscripto en el curso o no hay mas cupo.");
            }
        } catch (Exception ex)
        {
            Console.WriteLine($"Se capturó un error {ex.Message}");
        }
    }
    public void DarBajaAlumno (Curso curso, Alumno alumno)
    {
        try
        {
            curso.alumnos.Remove(alumno);
            alumno.cursos.Remove(curso);
            Console.WriteLine("Alumno dado de bajo con exito");   
        } catch (Exception ex)
        {
            Console.WriteLine($"Se encontro un error: {ex.Message}");
        }
    }
    public void CalcularHoras (Alumno alumno)
    {
        try
        {
            int canthora = 0;
            foreach (var p in alumno.cursos)
            {
                canthora = canthora + p.Duracion;
                Console.WriteLine($"Cantidad de horas del curso: {canthora}");
            }
        } catch (Exception ex)
        {
            Console.WriteLine($"Se capturó una excepcion_ {ex.Message}");
        }
    }
    public void ListarInscriptos(Curso curso)
    {
        try
        {
            foreach (var p in curso.alumnos)
            {
                Console.WriteLine($"Nombre: {p.Nombre} | Email: {p.Email}");
            }
        } catch (Exception ex)
        {
            Console.WriteLine($"Se capturo una excepcion: {ex.Message}");
        }
    }
}