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
            pbFondo.ImageLocation = "C:\\visual studio 2015\\Projects\\ProyectoMatrixFinal2018\\fondo.gif";
            //Shown += new EventHandler(Inicial_Shown);

            //// To report progress from the background worker we need to set this property
            //backgroundWorker1.WorkerReportsProgress = true;
            //// This event will be raised on the worker thread when the worker starts
            //backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            //// This event will be raised when we call ReportProgress
            //backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);



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
