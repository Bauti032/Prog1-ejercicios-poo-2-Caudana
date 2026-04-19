namespace Practicacs.Ejerciocio08_Prestamos;
public class Prestamo 
{
    public double MontoOtorgado {get;set;}
    public double TasaInteres {get;set;}
    public double CantCuotas {get;set;}
    public EstadoPrestamo Estado {get;set;}
    public double CantPorCuota {get;}

    public Prestamo (double monto, double tasainteres, double cantcuotas)
    {
        MontoOtorgado = monto;
        TasaInteres = tasainteres;
        CantCuotas = cantcuotas;
        Estado = EstadoPrestamo.Activo;
        CantPorCuota = (MontoOtorgado * (1 + TasaInteres)/CantCuotas);
    }
    public enum EstadoPrestamo
    {
        Activo = 1,
        Cancelado = 2,
    }
}