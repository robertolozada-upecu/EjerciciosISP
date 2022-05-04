using System.Collections.Generic;

namespace EjerciciosISP.Ejercicio1
{
    public interface IPago
    {
        string Estado();
        List<string> ObtenerPagos();
    }
    public interface IPagoPrestamo
    {
        void IniciarTotal();
        void IniciarAtrasado();
    }
    public interface IPagoBancario
    {
        void IniciarPago();
    }
}