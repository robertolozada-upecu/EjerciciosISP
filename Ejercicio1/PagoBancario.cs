using System;
using System.Collections.Generic;

namespace EjerciciosISP.Ejercicio1
{
    public class PagoBancario : IPago, IPagoBancario
    {
        public void IniciarPago()
        {
            
        }

        public string Estado()
        {
            return String.Empty;
        }

        public List<string> ObtenerPagos()
        {
            return new List<string>();
        }
    }
}