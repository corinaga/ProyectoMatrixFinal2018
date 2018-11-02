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
    public partial class Principal : Form
    {
        public Principal()
        {
            
            InitializeComponent();

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.progressBar1.Value = 0;
            this.progressBar1.Maximum = 20;
            timer1.Interval = 1000;
            timer1.Start();
            label1.Text = (progressBar1.Value.ToString() + "%");
        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            if (this.progressBar1.Value != 20)
            {
                //cada "tick" que es 1s la barra aumenta 1 
                this.progressBar1.Value += 1;
                //Lo multiplico por 5 para que llegue al 100% ya que el maximo valor de la barra es 20
                int progress = progressBar1.Value * 5;
                label1.Text = (progress.ToString() + "%");
            }
            else
            {
                timer1.Stop();
                this.Close();
            }
            //como su valor aumenta 1 cada segundo 
            if (this.progressBar1.Value % 2 == 0)
            {
                txtArea.Text = "Smith action";

            }
            if (this.progressBar1.Value % 5 == 0)
            {
                txtArea.Text = "Neo action";


            }







        }
    }
}
