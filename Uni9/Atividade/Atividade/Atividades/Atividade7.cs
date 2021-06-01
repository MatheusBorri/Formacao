using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade
{
    public partial class frmAt7 : Form
    {
        public frmAt7()
        {
            InitializeComponent();
        }

        private void btnIni_Click(object sender, EventArgs e)
        {

            int aux, valor = Convert.ToInt32(txtValor.Text);
            aux = 0;


            aux = valor * 2;
            txtResult.Text =  Convert.ToString(aux);
            for (int i = 3; i <= 11; i ++)
            {

                aux = valor * i;

                txtResult.Text = txtResult.Text + ", " + aux;
               
                

            }

            


        }
    }
}
