using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMatrixFinal2018.Matrix
{
    class Smith : Personage
    {

        public int infect;
        private readonly int MAX = 8;

        public Smith()
        {
            this.infect = getInfect();


        }


        public int getInfect()
        {
            return Useful.random_Number(1, this.MAX);
        }

    }
}
