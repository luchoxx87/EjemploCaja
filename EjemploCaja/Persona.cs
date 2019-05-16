using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploCaja
{
    public class Persona
    {
        public string Nombre { get; set; }
        public CajaForte CajaFuerte { get; private set; }

        public Persona(CajaForte cajaFuerte)
        {
            CajaFuerte = cajaFuerte;
        }
        public double dinero { get; set; }
        
          
        

    }
}
