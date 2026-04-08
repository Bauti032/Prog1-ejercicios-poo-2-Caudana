using Practicacs.Ejercicio01_Veterinaria;

public class SistemaVet
{
    private List<Animal> animales = new List<Animal>();

    public void RegistrarPaciente(Animal animal)
    {   
        try {
            animal.Activo = true;
            animales.Add(animal);
            Console.WriteLine($"Tipo {animal.Especie} | Nombre: {animal.Nombre} | Edad: {animal.Edad}. Agregado con exito.");
        } catch (Exception ex)
        {
            Console.WriteLine($"Se ah registrado una excepción: {ex}");
        }
    }
    public void BajaAnimal(Animal animal)
    {
        try
        {
            animal.Activo = false;
            // animales.Remove(animal);
            Console.WriteLine($"El animarl {animal.Nombre} fue removido de la lista");
        } catch (Exception ex)
        {
            Console.WriteLine($"Se ah registrado una excepcion: {ex}");
        }
    }
    public List<Animal> BuscarNombre(string nombre)
    {
        var resultados = animales.Where(a => a.Nombre.ToLower().Contains(nombre.ToLower())).ToList();

        if (resultados.Count == 0)
        {
            Console.WriteLine($"No se encontró ningún animal con el nombre '{nombre}'.");
            return resultados;
        }

        Console.WriteLine($"Animales encontrados para '{nombre}':");
        foreach (var animal in resultados)
        {
            Console.WriteLine($"Tipo: {animal.Especie} | Nombre: {animal.Nombre} | Edad: {animal.Edad} | Activo: {animal.Activo}");
        }

        return resultados;
    }
    public void ListarActivos()
    {
        foreach (var e in animales)
        {
            if (e.Activo == true)
            {
                Console.WriteLine($"| -{e.Nombre} |");
            }
        }
    }
}