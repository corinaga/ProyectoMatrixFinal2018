using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajonDesastre
{
    public partial class Form1 : Form
    {
        private Persona[,] lista;
        private Image dead;
        public Form1()
        {
            lista = new Persona[5, 5];

            for (int i = 0; i < lista.GetLength(0); i++)
            {
                for (int j = 0; j < lista.GetLength(1); j++)
                {
                    lista[i, j] = new Persona();
                }
            }

            
            Bitmap bm = new Bitmap(Image.FromFile("C:\\Users\\Fj Margotón\\Documents\\Visual Studio 2015\\Projects\\CajonDesastre\\CajonDesastre\\muerto.jpg"),130,130);
            this.dead = (Image)bm;

            InitializeComponent();
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;



            for (int i = 0; i < lista.GetLength(0); i++)
            {
                dataGridView1.Rows.Add(new DataGridViewRow());
                for (int j = 0; j < lista.GetLength(1); j++)
                {
                    if (lista[i, j] != null)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = lista[i, j].getImage();
                    }else
                    {
                        dataGridView1.Rows[i].Cells[j].Value = this.dead;
                    }
                    
                }
            }

        }


    }
}
