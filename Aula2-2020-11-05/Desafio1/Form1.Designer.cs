namespace Desafio1
{
    partial class FormVolume
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
            this.labelComprimento = new System.Windows.Forms.Label();
            this.labelLargura = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.textBoxComprimento = new System.Windows.Forms.TextBox();
            this.textBoxLargura = new System.Windows.Forms.TextBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.buttonCalcularVolume = new System.Windows.Forms.Button();
            this.labelVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelComprimento
            // 
            this.labelComprimento.AutoSize = true;
            this.labelComprimento.Location = new System.Drawing.Point(13, 13);
            this.labelComprimento.Name = "labelComprimento";
            this.labelComprimento.Size = new System.Drawing.Size(71, 13);
            this.labelComprimento.TabIndex = 0;
            this.labelComprimento.Text = "Comprimento:";
            // 
            // labelLargura
            // 
            this.labelLargura.AutoSize = true;
            this.labelLargura.Location = new System.Drawing.Point(13, 39);
            this.labelLargura.Name = "labelLargura";
            this.labelLargura.Size = new System.Drawing.Size(46, 13);
            this.labelLargura.TabIndex = 1;
            this.labelLargura.Text = "Largura:";
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(12, 66);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(37, 13);
            this.labelAltura.TabIndex = 2;
            this.labelAltura.Text = "Altura:";
            // 
            // textBoxComprimento
            // 
            this.textBoxComprimento.Location = new System.Drawing.Point(90, 10);
            this.textBoxComprimento.Name = "textBoxComprimento";
            this.textBoxComprimento.Size = new System.Drawing.Size(100, 20);
            this.textBoxComprimento.TabIndex = 3;
            // 
            // textBoxLargura
            // 
            this.textBoxLargura.Location = new System.Drawing.Point(90, 36);
            this.textBoxLargura.Name = "textBoxLargura";
            this.textBoxLargura.Size = new System.Drawing.Size(100, 20);
            this.textBoxLargura.TabIndex = 4;
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(90, 63);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(100, 20);
            this.textBoxAltura.TabIndex = 5;
            // 
            // buttonCalcularVolume
            // 
            this.buttonCalcularVolume.AutoSize = true;
            this.buttonCalcularVolume.Location = new System.Drawing.Point(97, 126);
            this.buttonCalcularVolume.Name = "buttonCalcularVolume";
            this.buttonCalcularVolume.Size = new System.Drawing.Size(93, 23);
            this.buttonCalcularVolume.TabIndex = 6;
            this.buttonCalcularVolume.Text = "Calcular Volume";
            this.buttonCalcularVolume.UseVisualStyleBackColor = true;
            this.buttonCalcularVolume.Click += new System.EventHandler(this.buttonCalcularVolume_Click);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(34, 110);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(226, 13);
            this.labelVolume.TabIndex = 7;
            this.labelVolume.Text = "Após digitar os valores, clicar no botão abaixo.";
            this.labelVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.buttonCalcularVolume);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBoxLargura);
            this.Controls.Add(this.textBoxComprimento);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.labelLargura);
            this.Controls.Add(this.labelComprimento);
            this.Name = "FormVolume";
            this.Text = "Calcular Volume Caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelComprimento;
        private System.Windows.Forms.Label labelLargura;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.TextBox textBoxComprimento;
        private System.Windows.Forms.TextBox textBoxLargura;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.Button buttonCalcularVolume;
        private System.Windows.Forms.Label labelVolume;
    }
}

