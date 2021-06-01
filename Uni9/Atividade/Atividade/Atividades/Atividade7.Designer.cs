
namespace Atividade
{
    partial class frmAt7
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
            this.btnIni = new System.Windows.Forms.Button();
            this.lblska = new System.Windows.Forms.Label();
            this.lblmul = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIni
            // 
            this.btnIni.Location = new System.Drawing.Point(235, 35);
            this.btnIni.Name = "btnIni";
            this.btnIni.Size = new System.Drawing.Size(75, 23);
            this.btnIni.TabIndex = 0;
            this.btnIni.Text = "Calcular";
            this.btnIni.UseVisualStyleBackColor = true;
            this.btnIni.Click += new System.EventHandler(this.btnIni_Click);
            // 
            // lblska
            // 
            this.lblska.AutoSize = true;
            this.lblska.Location = new System.Drawing.Point(32, 18);
            this.lblska.Name = "lblska";
            this.lblska.Size = new System.Drawing.Size(100, 15);
            this.lblska.TabIndex = 1;
            this.lblska.Text = "Escolha um valor:";
            // 
            // lblmul
            // 
            this.lblmul.AutoSize = true;
            this.lblmul.Location = new System.Drawing.Point(32, 89);
            this.lblmul.Name = "lblmul";
            this.lblmul.Size = new System.Drawing.Size(166, 15);
            this.lblmul.TabIndex = 2;
            this.lblmul.Text = "Os próximos 10 multiplos são:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(32, 36);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(156, 23);
            this.txtValor.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(32, 107);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(278, 23);
            this.txtResult.TabIndex = 4;
            // 
            // frmAt7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 178);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblmul);
            this.Controls.Add(this.lblska);
            this.Controls.Add(this.btnIni);
            this.Name = "frmAt7";
            this.Text = "Atividade 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIni;
        private System.Windows.Forms.Label lblska;
        private System.Windows.Forms.Label lblmul;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtResult;
    }
}