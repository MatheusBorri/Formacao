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
    public partial class frmAt5 : Form
    {
        public frmAt5()
        {
            InitializeComponent();
        }

        private void frmAt5_Load(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void btnMult_Click(object sender, EventArgs e)
        {


            int valor;


            valor = Convert.ToInt32(txtNum.Text);

            if (valor > 0  &&  valor <= 10)
            {

                lblval1.Text = Convert.ToString(valor);
                lblval2.Text = Convert.ToString(valor);
                lblval3.Text = Convert.ToString(valor);
                lblval4.Text = Convert.ToString(valor);
                lblval5.Text = Convert.ToString(valor);
                lblval6.Text = Convert.ToString(valor);
                lblval7.Text = Convert.ToString(valor);
                lblval8.Text = Convert.ToString(valor);
                lblval9.Text = Convert.ToString(valor);
                lblval10.Text = Convert.ToString(valor);
                lblval11.Text = Convert.ToString(valor);



                lblresult1.Text = Convert.ToString(valor * 0);
                lblresult2.Text = Convert.ToString(valor * 1);
                lblresult3.Text = Convert.ToString(valor * 2);
                lblresult4.Text = Convert.ToString(valor * 3);
                lblresult5.Text = Convert.ToString(valor * 4);
                lblresult6.Text = Convert.ToString(valor * 5);
                lblresult7.Text = Convert.ToString(valor * 6);
                lblresult8.Text = Convert.ToString(valor * 7);
                lblresult9.Text = Convert.ToString(valor * 8);
                lblresult10.Text = Convert.ToString(valor * 9);
                lblresult11.Text = Convert.ToString(valor * 10);


            }








        }
    }
}
