
namespace Atividade
{
    partial class frmAt6
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIni
            // 
            this.btnIni.Location = new System.Drawing.Point(72, 91);
            this.btnIni.Name = "btnIni";
            this.btnIni.Size = new System.Drawing.Size(75, 23);
            this.btnIni.TabIndex = 0;
            this.btnIni.Text = "Iniciar";
            this.btnIni.UseVisualStyleBackColor = true;
            this.btnIni.Click += new System.EventHandler(this.btnIni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calcular valor da série Geométrica S:";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(61, 50);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 23);
            this.txtResult.TabIndex = 2;
            // 
            // frmAt6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 140);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIni);
            this.Name = "frmAt6";
            this.Text = "Atividade 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
    }
}