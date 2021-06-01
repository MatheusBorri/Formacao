
namespace Atividade
{
    partial class frmAt8
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
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.lblda = new System.Windows.Forms.Label();
            this.lblsadha = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIni
            // 
            this.btnIni.Location = new System.Drawing.Point(98, 93);
            this.btnIni.Name = "btnIni";
            this.btnIni.Size = new System.Drawing.Size(93, 23);
            this.btnIni.TabIndex = 0;
            this.btnIni.Text = "Calcular!";
            this.btnIni.UseVisualStyleBackColor = true;
            this.btnIni.Click += new System.EventHandler(this.btnIni_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(148, 21);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 23);
            this.txtvalor.TabIndex = 2;
            // 
            // lblda
            // 
            this.lblda.AutoSize = true;
            this.lblda.Location = new System.Drawing.Point(39, 24);
            this.lblda.Name = "lblda";
            this.lblda.Size = new System.Drawing.Size(93, 15);
            this.lblda.TabIndex = 3;
            this.lblda.Text = "Digite o Fatorial:";
            // 
            // lblsadha
            // 
            this.lblsadha.AutoSize = true;
            this.lblsadha.Location = new System.Drawing.Point(39, 57);
            this.lblsadha.Name = "lblsadha";
            this.lblsadha.Size = new System.Drawing.Size(62, 15);
            this.lblsadha.TabIndex = 4;
            this.lblsadha.Text = "Resultado:";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(148, 54);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 23);
            this.txtResult.TabIndex = 5;
            // 
            // frmAt8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 138);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblsadha);
            this.Controls.Add(this.lblda);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.btnIni);
            this.Name = "frmAt8";
            this.Text = "Atividade 8";
            this.Load += new System.EventHandler(this.frmAt8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIni;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label lblda;
        private System.Windows.Forms.Label lblsadha;
        private System.Windows.Forms.TextBox txtResult;
    }
}