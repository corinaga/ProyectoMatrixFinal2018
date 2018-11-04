using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMatrixFinal2018
{
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = "hola";
        
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            this.textBox1.Text = "adios";
        }
    }
}
