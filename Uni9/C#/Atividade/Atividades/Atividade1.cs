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
    public partial class frmAt1 : Form
    {
        public frmAt1()
        {
            InitializeComponent();
        }

        private void btnCom_Click(object sender, EventArgs e)
        {

            txtresult.Text = "2";

            for (int i = 4; i <= 100; i= i +2)
            {
               

                txtresult.Text = txtresult.Text + ", " + Convert.ToString(i);

            }



        }

        private void frmAt1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
