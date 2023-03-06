
namespace PasswordGeneratorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerarSenha = new System.Windows.Forms.Button();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblQtdCaracteres = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerarSenha
            // 
            this.btnGerarSenha.BackColor = System.Drawing.Color.GreenYellow;
            this.btnGerarSenha.Location = new System.Drawing.Point(79, 93);
            this.btnGerarSenha.Name = "btnGerarSenha";
            this.btnGerarSenha.Size = new System.Drawing.Size(182, 23);
            this.btnGerarSenha.TabIndex = 0;
            this.btnGerarSenha.Text = "Gerar Senha";
            this.btnGerarSenha.UseVisualStyleBackColor = false;
            this.btnGerarSenha.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(79, 142);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(182, 23);
            this.tbSenha.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(216, 50);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 23);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQtdCaracteres
            // 
            this.lblQtdCaracteres.AutoSize = true;
            this.lblQtdCaracteres.Location = new System.Drawing.Point(79, 52);
            this.lblQtdCaracteres.Name = "lblQtdCaracteres";
            this.lblQtdCaracteres.Size = new System.Drawing.Size(131, 15);
            this.lblQtdCaracteres.TabIndex = 3;
            this.lblQtdCaracteres.Text = "Qtd Caracteres(Max 12)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 223);
            this.Controls.Add(this.lblQtdCaracteres);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.btnGerarSenha);
            this.Name = "Form1";
            this.Text = "Gerador de Senhas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarSenha;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblQtdCaracteres;
    }
}

