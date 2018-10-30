using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMatrixFinal2018.Matrix
{
    class Neo : Personage
    {
        public bool believed;

        public Neo()
        {

            this.believed = isBelieved();
        }

        public bool isBelieved()
        {
            int num = Useful.random_Number(0, 2);

            if (num == 0)
            {
                this.believed = false;
            }
            else
            {
                this.believed = true;
            }

            return this.believed;
        }



    }
}
