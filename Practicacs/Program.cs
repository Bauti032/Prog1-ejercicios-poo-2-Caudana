using Practicacs.Ejercicio01_Veterinaria;


Console.WriteLine("1. Veterinaria");
Console.WriteLine("Que Ejercicio queres probar?: ");
int op = Convert.ToInt32(Console.ReadLine());
switch (op)
{
        case 1:
        Ejercicio01_Veterinaria();
        break;
}



static void Ejercicio01_Veterinaria()
{
    Animal an1 = new Animal("Tobi", "Perro", 10);
    Animal an2 = new Animal("Rex", "Loro", 2);
    Animal an3 = new Animal("Tobi", "Gato", 10);

    SistemaVet sistv = new SistemaVet();

    sistv.RegistrarPaciente(an1);
    sistv.RegistrarPaciente(an2);
    sistv.RegistrarPaciente(an3);
    sistv.BajaAnimal(an2);
    sistv.BuscarNombre("Tobi");
    sistv.ListarActivos();
 }