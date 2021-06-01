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
    public partial class frmAt2 : Form
    {
        public frmAt2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIni_Click(object sender, EventArgs e)
        {
            int valor, aux;

            valor = Convert.ToInt32(txtValor.Text);
            aux = 0;

            for (int i = 1; i <= valor; i ++)
            {

                aux = aux + i;

            }

            txtResult.Text = Convert.ToString(aux);
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
