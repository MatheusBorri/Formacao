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
    public partial class frmAt6 : Form
    {
        public frmAt6()
        {
            InitializeComponent();
        }

        private void btnIni_Click(object sender, EventArgs e)
        {


            int valor = 0;

            for (int i = 12; i <= 103; i = i + 10)
            {

                valor = valor + i;

                txtResult.Text = Convert.ToString(valor);

            }







        }
    }
}
