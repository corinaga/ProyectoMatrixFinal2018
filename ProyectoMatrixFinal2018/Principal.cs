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
            Shown += new EventHandler(Principal_Shown);

            // To report progress from the background worker we need to set this property
            backgroundWorker1.WorkerReportsProgress = true;
            // This event will be raised on the worker thread when the worker starts
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            // This event will be raised when we call ReportProgress
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);

        }

        void Principal_Shown(object sender, EventArgs e)
        {
            // Start the background worker
            backgroundWorker1.RunWorkerAsync();
            
        }
        // On worker thread so do our thing!


        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            int max_time = 20;
            int time = 1;

            Matrix.Matrix m = new Matrix.Matrix();

           
            do
            {
                if (time % 1 == 0 && !m.end())
                {
                    //Accion del personaje
                    m.actionPg();


                }
                if (time % 2 == 0 && !m.end())
                {
                    //Accion de smith
                    m.smithAction2();

                }
                if (time % 5 == 0 && !m.end())
                 {
                    //Accion de neo
                    m.actionNeo();

                 }
                    backgroundWorker1.ReportProgress(time);
                System.Threading.Thread.Sleep(1000);
                time += 1;
                
                //nuevo.label1.Text = (progressBar1.Value.ToString() + "%");

            } while (time <= max_time && !m.end());

        }
        // Back on the 'UI' thread so we can update the progress bar
        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // The progress percentage is a property of e
            progressBar1.Value = e.ProgressPercentage;
            txtArea.Text += e.ProgressPercentage + String.Format(Environment.NewLine);
            // Aqui actualizamos el datagridview con los datos, osea el m.print que haciamos por consola

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
