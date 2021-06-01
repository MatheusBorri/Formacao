
namespace Atividade
{
    partial class frmAt2
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
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblqql = new System.Windows.Forms.Label();
            this.btnIni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(58, 119);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(71, 15);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Resultado é:";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(47, 149);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 23);
            this.txtResult.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(47, 55);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 7;
            // 
            // lblqql
            // 
            this.lblqql.AutoSize = true;
            this.lblqql.Location = new System.Drawing.Point(12, 24);
            this.lblqql.Name = "lblqql";
            this.lblqql.Size = new System.Drawing.Size(173, 15);
            this.lblqql.TabIndex = 6;
            this.lblqql.Text = "Digite o valor para o somatório:";
            // 
            // btnIni
            // 
            this.btnIni.Location = new System.Drawing.Point(58, 84);
            this.btnIni.Name = "btnIni";
            this.btnIni.Size = new System.Drawing.Size(75, 23);
            this.btnIni.TabIndex = 5;
            this.btnIni.Text = "Iniciar";
            this.btnIni.UseVisualStyleBackColor = true;
            this.btnIni.Click += new System.EventHandler(this.btnIni_Click);
            // 
            // frmAt2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 201);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblqql);
            this.Controls.Add(this.btnIni);
            this.Name = "frmAt2";
            this.Text = "Atividade 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblqql;
        private System.Windows.Forms.Button btnIni;
    }
}