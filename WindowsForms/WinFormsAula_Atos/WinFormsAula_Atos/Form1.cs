using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAula_Atos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNome_Click(object sender, EventArgs e)
        {

            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);
            int total = n1 + n2;
            //MessageBox.Show(total.ToString());
            lblResutado.Text = total.ToString();
            txtN1.Clear();
            txtN2.Clear();

            if (total % 2 == 0)
            {
                groupBox1.BackColor = Color.Red;
            }
            else
            {
                groupBox1.BackColor = Color.Blue;
            }

        }

        private void btnconfirmarIdade_Click(object sender, EventArgs e)
        {
            var n1 = int.Parse(txtIdade.Text);
            var n2 = txtNome.Text;

            //MessageBox.Show(total.ToString());
         
           

            if (n1 >= 18)
            {
                groupBox1.BackColor = Color.Red;
            }
            else
            {
                groupBox1.BackColor = Color.Blue;
            }
            txtN1.Clear();
            txtN2.Clear();
        }

        private void btnEsqueda_Click(object sender, EventArgs e)
        {
            btmCentro.Location = new Point(btmCentro.Location.X-5, btmCentro.Location.Y );
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            btmCentro.Location = new Point(btmCentro.Location.X + 5, btmCentro.Location.Y);
        }
    }
}
