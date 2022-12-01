using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2
{
    class Multiplica
    {
        private int multiplicando = 0; // Campo
        private int multiplicador = 0;

        public int Multiplicando //Propiedad
        {
            get { return multiplicando; }
            set { multiplicando = value; }

        }

        public int Multiplicador //Propiedad
        {
            get { return multiplicador; }
            set { multiplicador = value; }
        }



        public int Producto() //Metodo
        {
            int Total = 0;
            
            return Total = multiplicando * multiplicador;
        }

    }
}

