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
    public partial class frmAt8 : Form
    {
        public frmAt8()
        {
            InitializeComponent();
        }

        private void frmAt8_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIni_Click(object sender, EventArgs e)
        {


            int aux, valor = Convert.ToInt32(txtvalor.Text);

            aux = 1;

            if (valor == 0)
            {

                txtResult.Text = "0";

            }
            else
            {
                
                for (int i = valor; i > 1; i--)
                {
                    {
                        aux = aux * i;
                        txtResult.Text = Convert.ToString(aux);


                    }

                }


            }

        }

    }
}
