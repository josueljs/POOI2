namespace Desafio3
{
    partial class FormIMC
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAltura = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.buttonIMC = new System.Windows.Forms.Button();
            this.labelIMC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(13, 13);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(37, 13);
            this.labelAltura.TabIndex = 0;
            this.labelAltura.Text = "Altura:";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(13, 56);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(34, 13);
            this.labelPeso.TabIndex = 1;
            this.labelPeso.Text = "Peso:";
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(56, 10);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(100, 20);
            this.textBoxAltura.TabIndex = 2;
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(53, 53);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(100, 20);
            this.textBoxPeso.TabIndex = 3;
            // 
            // buttonIMC
            // 
            this.buttonIMC.Location = new System.Drawing.Point(108, 176);
            this.buttonIMC.Name = "buttonIMC";
            this.buttonIMC.Size = new System.Drawing.Size(75, 23);
            this.buttonIMC.TabIndex = 4;
            this.buttonIMC.Text = "Calcular IMC";
            this.buttonIMC.UseVisualStyleBackColor = true;
            this.buttonIMC.Click += new System.EventHandler(this.buttonIMC_Click);
            // 
            // labelIMC
            // 
            this.labelIMC.AutoSize = true;
            this.labelIMC.Location = new System.Drawing.Point(105, 160);
            this.labelIMC.Name = "labelIMC";
            this.labelIMC.Size = new System.Drawing.Size(70, 13);
            this.labelIMC.TabIndex = 5;
            this.labelIMC.Text = "Valor a exibir:";
            this.labelIMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.labelIMC);
            this.Controls.Add(this.buttonIMC);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.labelAltura);
            this.Name = "FormIMC";
            this.Text = "Cálculo de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.Button buttonIMC;
        private System.Windows.Forms.Label labelIMC;
    }
}

