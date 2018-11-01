using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajonDesastre
{
    class Persona
    {
        private String[] nombres = {"trinity","Neo","Smith","Juan","Conor" };
        private String nombre;
        private Image imagen;
        private Image[] imagenes = {
                Image.FromFile("C:\\Users\\Fj Margotón\\Documents\\Visual Studio 2015\\Projects\\CajonDesastre\\CajonDesastre\\trinity.png"),
                Image.FromFile("C:\\Users\\Fj Margotón\\Documents\\Visual Studio 2015\\Projects\\CajonDesastre\\CajonDesastre\\neo.png"),
                Image.FromFile("C:\\Users\\Fj Margotón\\Documents\\Visual Studio 2015\\Projects\\CajonDesastre\\CajonDesastre\\smith.png"),
                Image.FromFile("C:\\Users\\Fj Margotón\\Documents\\Visual Studio 2015\\Projects\\CajonDesastre\\CajonDesastre\\juan.png"),
                Image.FromFile("C:\\Users\\Fj Margotón\\Documents\\Visual Studio 2015\\Projects\\CajonDesastre\\CajonDesastre\\conor.png")
        };


        public Persona()
        {
            int numP = Useful.random_Number(0, nombres.Count()-1);
            this.nombre = this.nombres[numP];
            try
            {
                Image img = imagenes[numP];
                this.imagen = reSizeImg(img);
            }catch(Exception ex)
            {
                Console.WriteLine("Error");
            }
           
        }
        public Image reSizeImg(Image img)
        {
            int h = 130;
            int w = 130;
            Bitmap bm = new Bitmap(img, h, w);
            return (Image)bm;

        }
        public String getNombre()
        {
            return this.nombre;

        }
        public Image getImage()
        {
            return this.imagen;
        }
    }
}
