
namespace Atividade
{
    partial class frmAt4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblmost = new System.Windows.Forms.Label();
            this.txtResultP = new System.Windows.Forms.TextBox();
            this.txtcont = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnIni = new System.Windows.Forms.Button();
            this.lblasla = new System.Windows.Forms.Label();
            this.lblsin = new System.Windows.Forms.Label();
            this.lbldsa = new System.Windows.Forms.Label();
            this.txtResultN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "*Digite apenas um número por vez, quando o contador chegar a zero a aplicação ser" +
    "á reiniciada";
            // 
            // lblmost
            // 
            this.lblmost.AutoSize = true;
            this.lblmost.Location = new System.Drawing.Point(101, 181);
            this.lblmost.Name = "lblmost";
            this.lblmost.Size = new System.Drawing.Size(109, 15);
            this.lblmost.TabIndex = 14;
            this.lblmost.Text = "Números Positivos:";
            // 
            // txtResultP
            // 
            this.txtResultP.Enabled = false;
            this.txtResultP.Location = new System.Drawing.Point(126, 212);
            this.txtResultP.Name = "txtResultP";
            this.txtResultP.Size = new System.Drawing.Size(281, 23);
            this.txtResultP.TabIndex = 13;
            // 
            // txtcont
            // 
            this.txtcont.Enabled = false;
            this.txtcont.Location = new System.Drawing.Point(322, 80);
            this.txtcont.Name = "txtcont";
            this.txtcont.Size = new System.Drawing.Size(100, 23);
            this.txtcont.TabIndex = 12;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(101, 80);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 11;
            // 
            // btnIni
            // 
            this.btnIni.Location = new System.Drawing.Point(116, 137);
            this.btnIni.Name = "btnIni";
            this.btnIni.Size = new System.Drawing.Size(75, 23);
            this.btnIni.TabIndex = 10;
            this.btnIni.Text = "Testar";
            this.btnIni.UseVisualStyleBackColor = true;
            this.btnIni.Click += new System.EventHandler(this.btnIni_Click);
            // 
            // lblasla
            // 
            this.lblasla.AutoSize = true;
            this.lblasla.Location = new System.Drawing.Point(337, 43);
            this.lblasla.Name = "lblasla";
            this.lblasla.Size = new System.Drawing.Size(60, 15);
            this.lblasla.TabIndex = 9;
            this.lblasla.Text = "Contador:";
            // 
            // lblsin
            // 
            this.lblsin.AutoSize = true;
            this.lblsin.Location = new System.Drawing.Point(86, 43);
            this.lblsin.Name = "lblsin";
            this.lblsin.Size = new System.Drawing.Size(148, 15);
            this.lblsin.TabIndex = 8;
            this.lblsin.Text = "Digite um número por vez:";
            // 
            // lbldsa
            // 
            this.lbldsa.AutoSize = true;
            this.lbldsa.Location = new System.Drawing.Point(101, 237);
            this.lbldsa.Name = "lbldsa";
            this.lbldsa.Size = new System.Drawing.Size(115, 15);
            this.lbldsa.TabIndex = 17;
            this.lbldsa.Text = "Números Negativos:";
            // 
            // txtResultN
            // 
            this.txtResultN.Enabled = false;
            this.txtResultN.Location = new System.Drawing.Point(126, 268);
            this.txtResultN.Name = "txtResultN";
            this.txtResultN.Size = new System.Drawing.Size(281, 23);
            this.txtResultN.TabIndex = 16;
            // 
            // frmAt4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 312);
            this.Controls.Add(this.lbldsa);
            this.Controls.Add(this.txtResultN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmost);
            this.Controls.Add(this.txtResultP);
            this.Controls.Add(this.txtcont);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnIni);
            this.Controls.Add(this.lblasla);
            this.Controls.Add(this.lblsin);
            this.Name = "frmAt4";
            this.Text = "Atividade 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmost;
        private System.Windows.Forms.TextBox txtResultP;
        private System.Windows.Forms.TextBox txtcont;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnIni;
        private System.Windows.Forms.Label lblasla;
        private System.Windows.Forms.Label lblsin;
        private System.Windows.Forms.Label lbldsa;
        private System.Windows.Forms.TextBox txtResultN;
    }
}