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
    public partial class pildoraAzul : Form
    {
        
        public pildoraAzul()
        {
            InitializeComponent();
            this.CenterToScreen();
            String video = Directory.GetParent(Directory.GetParent(Application.StartupPath).ToString()).ToString() + "\\principal\\pildoraAzul.mp4";


            this.axWindowsMediaPlayer1.URL = video;
            //axWindowsMediaPlayer1.MediaEnded += media_MediaEnded;
            
        }


    }
}
