namespace WindowsFormsApp1
{
    partial class FormMedia
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
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNota1 = new System.Windows.Forms.Label();
            this.textBoxNota1 = new System.Windows.Forms.TextBox();
            this.labelNota2 = new System.Windows.Forms.Label();
            this.textBoxNota2 = new System.Windows.Forms.TextBox();
            this.buttonCalcularMedia = new System.Windows.Forms.Button();
            this.labelRetornaMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(13, 13);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(55, 13);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelNota1
            // 
            this.labelNota1.AutoSize = true;
            this.labelNota1.Location = new System.Drawing.Point(13, 62);
            this.labelNota1.Name = "labelNota1";
            this.labelNota1.Size = new System.Drawing.Size(39, 13);
            this.labelNota1.TabIndex = 2;
            this.labelNota1.Text = "Nota 1";
            // 
            // textBoxNota1
            // 
            this.textBoxNota1.Location = new System.Drawing.Point(55, 59);
            this.textBoxNota1.Name = "textBoxNota1";
            this.textBoxNota1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNota1.TabIndex = 3;
            // 
            // labelNota2
            // 
            this.labelNota2.AutoSize = true;
            this.labelNota2.Location = new System.Drawing.Point(16, 109);
            this.labelNota2.Name = "labelNota2";
            this.labelNota2.Size = new System.Drawing.Size(39, 13);
            this.labelNota2.TabIndex = 4;
            this.labelNota2.Text = "Nota 2";
            // 
            // textBoxNota2
            // 
            this.textBoxNota2.Location = new System.Drawing.Point(55, 106);
            this.textBoxNota2.Name = "textBoxNota2";
            this.textBoxNota2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNota2.TabIndex = 5;
            // 
            // buttonCalcularMedia
            // 
            this.buttonCalcularMedia.AutoSize = true;
            this.buttonCalcularMedia.Location = new System.Drawing.Point(55, 160);
            this.buttonCalcularMedia.Name = "buttonCalcularMedia";
            this.buttonCalcularMedia.Size = new System.Drawing.Size(87, 23);
            this.buttonCalcularMedia.TabIndex = 6;
            this.buttonCalcularMedia.Text = "Calcular Média";
            this.buttonCalcularMedia.UseVisualStyleBackColor = true;
            this.buttonCalcularMedia.Click += new System.EventHandler(this.buttonCalcularMedia_Click);
            // 
            // labelRetornaMedia
            // 
            this.labelRetornaMedia.AutoSize = true;
            this.labelRetornaMedia.Location = new System.Drawing.Point(55, 218);
            this.labelRetornaMedia.Name = "labelRetornaMedia";
            this.labelRetornaMedia.Size = new System.Drawing.Size(181, 13);
            this.labelRetornaMedia.TabIndex = 7;
            this.labelRetornaMedia.Text = "Após digitar as notas, clicar no botão";
            // 
            // FormMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelRetornaMedia);
            this.Controls.Add(this.buttonCalcularMedia);
            this.Controls.Add(this.textBoxNota2);
            this.Controls.Add(this.labelNota2);
            this.Controls.Add(this.textBoxNota1);
            this.Controls.Add(this.labelNota1);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Name = "FormMedia";
            this.Text = "Calcular Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNota1;
        private System.Windows.Forms.TextBox textBoxNota1;
        private System.Windows.Forms.Label labelNota2;
        private System.Windows.Forms.TextBox textBoxNota2;
        private System.Windows.Forms.Button buttonCalcularMedia;
        private System.Windows.Forms.Label labelRetornaMedia;
    }
}

