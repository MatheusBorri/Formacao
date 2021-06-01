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
    public partial class frmAt3 : Form
    {

        int cont;
        public frmAt3()
        {
            InitializeComponent();
           
        }

        private void btnIni_Click(object sender, EventArgs e)
        {


            double num;
            
            num = Convert.ToDouble(txtValor.Text);

            if (num < 0)
            {

                txtResult.Text = txtResult.Text + " " + Convert.ToString(num);

            }

            cont = cont + 1;

            

            if (cont == 11)
            {

                txtResult.Text = "";
                cont = 0;
            }

            txtcont.Text = Convert.ToString(cont);
        }

        private void Atividade3_Load(object sender, EventArgs e)
        {

        }
    }
}
