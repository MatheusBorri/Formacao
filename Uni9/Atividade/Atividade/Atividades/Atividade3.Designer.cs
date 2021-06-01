
namespace Atividade
{
    partial class frmAt3
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
            this.lblsin = new System.Windows.Forms.Label();
            this.lblasla = new System.Windows.Forms.Label();
            this.btnIni = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtcont = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblmost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblsin
            // 
            this.lblsin.AutoSize = true;
            this.lblsin.Location = new System.Drawing.Point(75, 43);
            this.lblsin.Name = "lblsin";
            this.lblsin.Size = new System.Drawing.Size(148, 15);
            this.lblsin.TabIndex = 0;
            this.lblsin.Text = "Digite um número por vez:";
            // 
            // lblasla
            // 
            this.lblasla.AutoSize = true;
            this.lblasla.Location = new System.Drawing.Point(326, 43);
            this.lblasla.Name = "lblasla";
            this.lblasla.Size = new System.Drawing.Size(60, 15);
            this.lblasla.TabIndex = 1;
            this.lblasla.Text = "Contador:";
            // 
            // btnIni
            // 
            this.btnIni.Location = new System.Drawing.Point(105, 137);
            this.btnIni.Name = "btnIni";
            this.btnIni.Size = new System.Drawing.Size(75, 23);
            this.btnIni.TabIndex = 2;
            this.btnIni.Text = "Testar";
            this.btnIni.UseVisualStyleBackColor = true;
            this.btnIni.Click += new System.EventHandler(this.btnIni_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(90, 80);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 3;
            // 
            // txtcont
            // 
            this.txtcont.Enabled = false;
            this.txtcont.Location = new System.Drawing.Point(311, 80);
            this.txtcont.Name = "txtcont";
            this.txtcont.Size = new System.Drawing.Size(100, 23);
            this.txtcont.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(115, 212);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(281, 23);
            this.txtResult.TabIndex = 5;
            // 
            // lblmost
            // 
            this.lblmost.AutoSize = true;
            this.lblmost.Location = new System.Drawing.Point(90, 181);
            this.lblmost.Name = "lblmost";
            this.lblmost.Size = new System.Drawing.Size(115, 15);
            this.lblmost.TabIndex = 6;
            this.lblmost.Text = "Números Negativos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "*Digite apenas um número por vez, quando o contador chegar a zero a aplicação ser" +
    "á reiniciada";
            // 
            // frmAt3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 247);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmost);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtcont);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnIni);
            this.Controls.Add(this.lblasla);
            this.Controls.Add(this.lblsin);
            this.Name = "frmAt3";
            this.Text = "Atividade 3";
            this.Load += new System.EventHandler(this.Atividade3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsin;
        private System.Windows.Forms.Label lblasla;
        private System.Windows.Forms.Button btnIni;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtcont;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblmost;
        private System.Windows.Forms.Label label1;
    }
}