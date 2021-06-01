
namespace Atividade
{
    partial class frmAt9
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
            this.lbldas = new System.Windows.Forms.Label();
            this.btnVeri = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lbldww = new System.Windows.Forms.Label();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldas
            // 
            this.lbldas.AutoSize = true;
            this.lbldas.Location = new System.Drawing.Point(32, 29);
            this.lbldas.Name = "lbldas";
            this.lbldas.Size = new System.Drawing.Size(148, 15);
            this.lbldas.TabIndex = 0;
            this.lbldas.Text = "Digite um número por vez:";
            // 
            // btnVeri
            // 
            this.btnVeri.Location = new System.Drawing.Point(211, 67);
            this.btnVeri.Name = "btnVeri";
            this.btnVeri.Size = new System.Drawing.Size(75, 23);
            this.btnVeri.TabIndex = 1;
            this.btnVeri.Text = "Testar!";
            this.btnVeri.UseVisualStyleBackColor = true;
            this.btnVeri.Click += new System.EventHandler(this.btnVeri_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(186, 26);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 2;
            // 
            // lbldww
            // 
            this.lbldww.AutoSize = true;
            this.lbldww.Location = new System.Drawing.Point(306, 29);
            this.lbldww.Name = "lbldww";
            this.lbldww.Size = new System.Drawing.Size(60, 15);
            this.lbldww.TabIndex = 3;
            this.lbldww.Text = "Contador:";
            // 
            // txtCont
            // 
            this.txtCont.Enabled = false;
            this.txtCont.Location = new System.Drawing.Point(372, 26);
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(100, 23);
            this.txtCont.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(32, 129);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 5;
            // 
            // frmAt9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 156);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.lbldww);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnVeri);
            this.Controls.Add(this.lbldas);
            this.Name = "frmAt9";
            this.Text = "Atividade 9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldas;
        private System.Windows.Forms.Button btnVeri;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lbldww;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.Label lblResult;
    }
}