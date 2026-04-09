namespace Practicacs.Ejercicio03_Estacionamiento;
public class Sistestacion
{
    public void IngresoVeh (Vehiculo vehiculo, Estacionamiento estacionamiento)
    {
        try
        {
            if (estacionamiento.vehiculos.Count() < estacionamiento.CapMaxi)
            {
                estacionamiento.vehiculos.Add(vehiculo);
                Console.WriteLine($"Se ah ingresado el vehículo con patente {vehiculo.Patente}");
            } else {
                Console.WriteLine("La capacidad esta al maximo");
            }
        } catch (Exception ex)
        {
            Console.WriteLine($"Se ah encontrado una excepción: {ex}");
        }
    }
    public void EgresoVeh (Vehiculo vehiculo, Estacionamiento estacionamiento)
    {
        try
        {
            estacionamiento.vehiculos.Remove(vehiculo);
            Console.WriteLine($"Se retiró el vehículo con patente {vehiculo.Patente}");
        } catch (Exception ex)
        {
            Console.WriteLine($"Se ah encontrado una excepción: {ex}");
        }
    }
    public void BuscarVeh(Estacionamiento estacionamiento, string patente)
    {
        bool encontrado = false;
        foreach (var e in estacionamiento.vehiculos)
        {
            if (e.Patente == patente)
            {
                encontrado = true;
                break;
            }
        }
        if (encontrado)
        {
            Console.WriteLine($"El vehículo con patente {patente} está estacionado.");
        }
        else
        {
            Console.WriteLine($"El vehículo con patente {patente} no está estacionado.");
        }
    }
    public void CuentaEstacionados(Estacionamiento estacionamiento) {
        int result = 0;
        result = estacionamiento.CapMaxi - estacionamiento.vehiculos.Count();
        Console.WriteLine($"Quedan {result} lugares");
    }
}