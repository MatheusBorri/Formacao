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
    public partial class frmAt9 : Form
    {
        int cont = 0;
        int aux = 0;
        public frmAt9()
        {
            InitializeComponent();
            
        }

        private void btnVeri_Click(object sender, EventArgs e)
        {

            int valor;

            valor = Convert.ToInt32(txtValor.Text);

            

            if (aux < valor)
            {
                aux = valor;

            }

            if (cont == 5)
            {

                lblResult.Text = "Maior valor digitado foi: " + Convert.ToString(aux);
                cont = 0;
                aux = 0;
                
            }

            if (cont == 2)
            {
                lblResult.Text = "";

            }
                cont = cont + 1;
            txtCont.Text = Convert.ToString(cont);

        }
    }
}
