using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2
{
    public partial class Form1 : Form
    {
 
        int Total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void cmdMostrar_Click(object sender, EventArgs e)
        {

            

            Multiplica pMult = new Multiplica();
            pMult.Multiplicando = Convert.ToInt16(txtMult.Text);
            int r = Convert.ToInt16(txtRangoInicio.Text);
            int f = Convert.ToInt16(txtRangoFinal.Text);




            for (int i = r ; i <= f; i++)
            {
                dataGridView1.Rows.Add(new object[] { pMult.Multiplicando, i, pMult.Producto() });
            }
        }
    }
}
