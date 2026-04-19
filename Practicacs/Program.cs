using Practicacs.Ejercicio01_Veterinaria;
using Practicacs.Ejericio02_Gimnasio;
using Practicacs.Ejercicio03_Estacionamiento;
using Practicacs.Ejercicio04_Musica;
using Practicacs.Ejercicio05_Encomienda;
using Practicacs.Ejercicio06_Turnos;
using Practicacs.Ejercicio07_PlatCurso;
using Practicacs.Ejerciocio08_Prestamos;

Console.WriteLine("1. Veterinaria");
Console.WriteLine("2. Gimnasio");
Console.WriteLine("3. Estacionamiento");
Console.WriteLine("4. Musica");
Console.WriteLine("5. Encomienda");
Console.WriteLine("6. Turnos");
Console.WriteLine("7. Sistemas Cursos");
Console.WriteLine("8. Prestamos");
Console.WriteLine("Que Ejercicio queres probar?: ");
int op = Convert.ToInt32(Console.ReadLine());
switch (op)
{
        case 1:
        Ejercicio01_Veterinaria();
        break;
        case 2:
        Ejericio02_Gimnasio();
        break;
        case 3:
        Ejercicio03_Estacionamiento();
        break;
        case 4:
        Ejercicio04_Musica();
        break;
        case 5:
        Ejercicio05_Encomienda();
        break;
        case 6:
        Ejercicio06_Turnos();
        break;
        case 7:
        Ejercicio07_PlatCurso();
        break;
        case 8:
        Ejercicio08_Prestamos();
        break;
        default:
        Console.WriteLine("Opcion no valida. Ponelo bien, gil de goma.");
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

static void Ejericio02_Gimnasio()
{
    Socio s1 = new Socio("Bautista", 20202);
    Socio s2 = new Socio("Dario", 2313);
    Socio s3 = new Socio("Micho", 101010);

    Gimnasio g1 = new Gimnasio("Luka", 3);
    SistemaGym sgym = new SistemaGym();

    sgym.AgregarSocio(s1, g1);
    sgym.AgregarSocio(s2, g1);
    sgym.AgregarSocio(s3, g1);
    sgym.AgregarSocio(s3, g1);

    sgym.DarBaja(s2, g1);
    sgym.CanDia(g1);
    sgym.MarcarCuota(s3, "Vencida");
    sgym.CanDia(g1);
}
static void Ejercicio03_Estacionamiento()
{
    Vehiculo veh1 = new Vehiculo("Dario", "AB343JP");
    Vehiculo veh2 = new Vehiculo("Bautista", "AA000ZZ");
    Vehiculo veh3 = new Vehiculo("Luca", "AB002AA");
    Estacionamiento est1 = new Estacionamiento("LOTUS", 3);

    Sistestacion sistest = new Sistestacion();

    sistest.IngresoVeh(veh1, est1);
    sistest.IngresoVeh(veh2, est1);
    sistest.IngresoVeh(veh3, est1);

    sistest.CuentaEstacionados(est1);
    sistest.EgresoVeh(veh2, est1);
    sistest.BuscarVeh(est1, "AB343JP");
    sistest.BuscarVeh(est1, "AA000ZZ");
    sistest.CuentaEstacionados(est1);
}
static void Ejercicio04_Musica()
{
    Instrumento i1 = new Instrumento("Guitarra", "Cuerda", 1500);
    Instrumento i2 = new Instrumento("Bateria", "Percusion", 3000);
    Instrumento i3 = new Instrumento("Piano", "Teclado", 5000);

    SisTienda tienda = new SisTienda();

    tienda.AgregarInstrumento(i1);
    tienda.AgregarInstrumento(i2);
    tienda.AgregarInstrumento(i3);

    Console.WriteLine("Instrumentos de categoria 'Cuerda':");
    var cuerda = tienda.BuscarPorCategoria("Cuerda");
    foreach (var instrumento in cuerda)
    {
        Console.WriteLine($"Nombre: {instrumento.Nombre} | Precio: {instrumento.Precio}");
    }

    Console.WriteLine($"Valor total del inventario: {tienda.CalcularValorTotalInventario()}");
}
static void Ejercicio05_Encomienda()
{
    Encomienda en1 = new Encomienda("123DA", "Bautista", "Dario");
    Encomienda en2 = new Encomienda("111AD", "Micho", "Tito");

    SistEncomienda sisten = new SistEncomienda();
    sisten.AgregarEncomienda(en1);
    sisten.AgregarEncomienda(en2);

    sisten.AvanzarEncomienda(en1);
    sisten.AveriguarEncomienda(en1);
    sisten.AvanzarEncomienda(en1);
    sisten.AvanzarEncomienda(en2);
    sisten.ListarEncomiendas();
}
static void Ejercicio06_Turnos()
{
    Peluquero p1 = new Peluquero("Luca");
    Peluquero p2 = new Peluquero("Dario");

    Turno t1 = new Turno("2024-07-01", "10:00", "Bautista", "Corte de pelo");
    Turno t2 = new Turno("2024-07-01", "11:00", "Micho", "Coloracion");
    Turno t3 = new Turno("2024-07-01", "10:00", "Tito", "Peinado");

    SistTurno sistturno = new SistTurno();
    sistturno.AgregarPeluquero(p1);
    sistturno.AgregarPeluquero(p2);

    sistturno.AsignarTurno(p1, t1);
    sistturno.AsignarTurno(p1, t2);
    sistturno.AsignarTurno(p1, t3);

    sistturno.ListarTurnos(p1, "2024-07-01");
    Console.WriteLine($"Disponibilidad de {p1.Nombre} el 2024-07-01 a las 10:00: {sistturno.VerificarDisponibilidad(p1, "2024-07-01", "10:00")}");
    Console.WriteLine($"Disponibilidad de {p1.Nombre} el 2024-07-01 a las 11:00: {sistturno.VerificarDisponibilidad(p1, "2024-07-01", "11:00")}");
}
static void Ejercicio07_PlatCurso()
{
    Curso c1 = new Curso("Excel", "Manejas excel como boludin", 20, 2);
    Curso c2 = new Curso("Programacion", "Aca no sabes quien sos", 15, 2);
    Alumno a1 = new Alumno("Bautista", "caudanabautista002@gmail.com");
    Alumno a2 = new Alumno("Nicolas", "nicoalvarez002@gmail.com");

    Sistemacurso sistc = new Sistemacurso();

    sistc.AgregarAlumno(c1, a1);
    sistc.AgregarAlumno(c1, a2);
    sistc.AgregarAlumno(c2, a2);
    sistc.AgregarAlumno(c2, a1);
    sistc.CalcularHoras(a1);
    sistc.DarBajaAlumno(c1, a1);
    sistc.ListarInscriptos(c2);
}
static void Ejercicio08_Prestamos()
{
    Cliente cliente1 = new Cliente("Bautista", "20-20202020-2");
    Prestamo prestamo1 = new Prestamo(10000, 0.2, 12);
    Prestamo prestamo2 = new Prestamo(5000, 0.15, 6);   
    SistemaPrestamo sistprestamo = new SistemaPrestamo();
    sistprestamo.AgregarPrestamo(cliente1, prestamo1);
    sistprestamo.AgregarPrestamo(cliente1, prestamo2);
    sistprestamo.CalcularValorCuota(cliente1);
    sistprestamo.CancelarPrestamo(cliente1, 1);
    sistprestamo.CalcularDeudaTotalVigente(cliente1);
    sistprestamo.VerificarNuevoPrestamo(cliente1);
    
}