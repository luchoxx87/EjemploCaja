using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploCaja
{
    public class CajaForte
    {
        public int Aperturas { get; private set; }
        public double Saldo { get; private set; }

        public CajaForte()
        {
            Aperturas = 0;
            Saldo = 0;
        }

        public void acreditar(double unMonto)
        {
            abrirPuerta();
            Saldo += unMonto;
        }

        public double retirar(double unMonto)
        {
            double devolucion;
            if (unMonto<=Saldo)
            {
                abrirPuerta();
                Saldo -= unMonto;
                devolucion = unMonto;
            }
            else
            {
                devolucion = 0;
            }
            return devolucion;
        }

        private void abrirPuerta()
        {
            Aperturas++;
        }
    }
}
