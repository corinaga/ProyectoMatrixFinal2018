﻿using System;
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
        private pildoraAzul pildoraAzul;
        private pildoraRoja pildoraRoja;
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
            this.pildoraRoja = new pildoraRoja();
            this.pildoraRoja.Show();


        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.pildoraAzul = new pildoraAzul();
            this.pildoraAzul.Show();
            
        }

        private void Final_Load(object sender, EventArgs e)
        {

        }

        private void Final_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
