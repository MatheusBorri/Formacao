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
    public partial class FrmAtividade : Form
    {
        public FrmAtividade()
        {
            InitializeComponent();
        }

        private void btnAt1_Click(object sender, EventArgs e)
        {
            frmAt1 novaform = new frmAt1();
            novaform.Show();


        }

        private void btnAt2_Click(object sender, EventArgs e)
        {
            frmAt2 novaform = new frmAt2 ();
            novaform.Show();
        }

        private void btnAt3_Click(object sender, EventArgs e)
        {
            frmAt3 novaform = new frmAt3();
            novaform.Show();
        }

        private void btnAt4_Click(object sender, EventArgs e)
        {
            frmAt4 novaform = new frmAt4();
            novaform.Show();
        }

        private void BtnAt5_Click(object sender, EventArgs e)
        {
            frmAt5 novaform = new frmAt5();
            novaform.Show();
        }

        private void btnAt6_Click(object sender, EventArgs e)
        {
            frmAt6 novaform = new frmAt6();
            novaform.Show();
        }

        private void BtnAt7_Click(object sender, EventArgs e)
        {
            frmAt7 novaform = new frmAt7();
            novaform.Show();

        }

        private void btnAt8_Click(object sender, EventArgs e)
        {
            frmAt8 novaform = new frmAt8();
            novaform.Show();

        }

        private void btnAt9_Click(object sender, EventArgs e)
        {
            frmAt9 novaform = new frmAt9();
            novaform.Show();

        }
    }
}
