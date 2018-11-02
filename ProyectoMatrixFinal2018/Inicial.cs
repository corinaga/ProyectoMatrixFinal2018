using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMatrixFinal2018
{
    public partial class Inicial : Form
    {

        private Principal principal;
        public Inicial()
        {
            principal = new Principal();

            InitializeComponent();
            pbFondo.ImageLocation = "..\\..\\principal\\fondo.gif";
            


        }

        private void pbFondo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            principal.Show();
        }
    }
}
