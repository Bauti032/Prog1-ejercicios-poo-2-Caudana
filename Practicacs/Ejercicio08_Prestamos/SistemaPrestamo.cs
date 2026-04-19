namespace Practicacs.Ejerciocio08_Prestamos;
public class SistemaPrestamo
{
    public void AgregarPrestamo(Cliente cliente, Prestamo prestamo)
    {
        try
        {
            cliente.prestamos.Add(prestamo);
            Console.WriteLine("Prestamo Agregado con éxito.");
        } catch (Exception ex)
        {
            Console.WriteLine($"Se ah producido una excepcion: {ex.Message}");
        }
    }
    public void CalcularValorCuota (Cliente cliente)
    {
        try
        {
            int c = 0;
        foreach (var p in cliente.prestamos)
        {
            c ++;
            Console.WriteLine($"Presamo N°{c}. El valor de cada cuota es de: ${p.CantPorCuota}");
        }
        } catch (Exception ex)
        {
            Console.WriteLine($"Se ah producido un error {ex.Message}");
        }
    }
    public void CancelarPrestamo (Cliente cliente, int numeroPrestamo)
    {
        try
        {
            if (cliente.prestamos[numeroPrestamo - 1].Estado == Prestamo.EstadoPrestamo.Activo)
            {
                cliente.prestamos[numeroPrestamo - 1].Estado = Prestamo.EstadoPrestamo.Cancelado;
                Console.WriteLine($"El prestamo N°{numeroPrestamo} ah sido cancelado con éxito.");
            } else
            {
                Console.WriteLine($"El prestamo N°{numeroPrestamo} ya se encuentra cancelado.");
            }
        } catch (Exception ex)
        {
            Console.WriteLine($"Se ah producido un error {ex.Message}");
        }
    }
    public void CalcularDeudaTotalVigente (Cliente cliente)
    {
        try
        {
            double deudaTotal = 0;
            foreach (var p in cliente.prestamos)
            {
                if (p.Estado == Prestamo.EstadoPrestamo.Activo)
                {
                    deudaTotal += p.MontoOtorgado * (1 + p.TasaInteres);
                }
            }
            Console.WriteLine($"La deuda total vigente del cliente {cliente.Nombre} es de: ${deudaTotal}");
        } catch (Exception ex)
        {
            Console.WriteLine($"Se ah producido un error {ex.Message}");
        }
    }
    public void VerificarNuevoPrestamo (Cliente cliente)
    {
        try
        {
            int prestamosActivos = 0;
            foreach (var p in cliente.prestamos)
            {
                if (p.Estado == Prestamo.EstadoPrestamo.Activo)
                {
                    prestamosActivos++;
                }
            }
            if (prestamosActivos < 2)
            {
                Console.WriteLine($"El cliente {cliente.Nombre} puede solicitar un nuevo préstamo.");
            } else
            {
                Console.WriteLine($"El cliente {cliente.Nombre} no puede solicitar un nuevo préstamo, ya tiene {prestamosActivos} préstamos activos.");
            }
        } catch (Exception ex)
        {
            Console.WriteLine($"Se ah producido un error {ex.Message}");
        }
    }

}