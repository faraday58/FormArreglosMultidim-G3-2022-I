using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matrices;
namespace FormArreglosMultidim_G3_2022_I
{
    public partial class Form1 : Form
    {
        Multidimensional m1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {



            m1 = Multidimensional.Leer(txtbMatriz.Text);
            lbMatriz1.Text = m1.ToString();

        }

        private void btnSen_Click(object sender, EventArgs e)
        {
            if(rdbDeg.Checked)
            {

            }
            else if( rdbRad.Checked)
            {

            }
        }
    }
}
