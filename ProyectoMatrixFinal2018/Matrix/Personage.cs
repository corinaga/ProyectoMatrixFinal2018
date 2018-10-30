using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMatrixFinal2018.Matrix
{
    class Personage : Generic
    {
        private String name;
        private readonly String[] names = { "Michelle ", "Alexander", "James    ", "Caroline ", "Claire   ", "Jessica  ", "Erik     ", "Mike     " };
        private int age;
        private int percentageDie;
        private Location location;



        public Personage()
        {
            this.name = names[Useful.random_Number(0, 7)];
            this.age = Useful.random_Number(1, 100);
            this.percentageDie = Useful.random_Number(1, 101);
            this.location = new Location();
        }


        internal class Location
        {
            private readonly String[] cities = { "Nueva York", "Boston", "Baltimore", "Atlanta", "Detroit", "Dallas", "Denver" };
            public int latitude;
            public int longitude;
            public String city;

            public Location()
            {
                this.city = cities[Useful.random_Number(0, 7)];
                this.latitude = Useful.random_Number(0, 91);
                this.longitude = Useful.random_Number(0, 360);
            }

        }

        public void generate()
        {
            throw new NotImplementedException();
        }

        public void print()
        {
            throw new NotImplementedException();
        }

        public void prompt()
        {
            throw new NotImplementedException();
        }

        public String getNombre()
        {
            return this.name;
        }

        public int getPercentageDie()
        {
            return this.percentageDie;
        }

        public void setPercentageDie(int per)
        {
            this.percentageDie = per;
        }

    }
}
