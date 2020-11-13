namespace Desafio1
{
    partial class FormSomaQuad
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
            this.labelNum1 = new System.Windows.Forms.Label();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.labelNum3 = new System.Windows.Forms.Label();
            this.textBoxNum3 = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Location = new System.Drawing.Point(13, 13);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(84, 13);
            this.labelNum1.TabIndex = 0;
            this.labelNum1.Text = "Primeiro Número";
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Location = new System.Drawing.Point(103, 10);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum1.TabIndex = 1;
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Location = new System.Drawing.Point(13, 59);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(90, 13);
            this.labelNum2.TabIndex = 2;
            this.labelNum2.Text = "Segundo Número";
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(103, 56);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum2.TabIndex = 3;
            // 
            // labelNum3
            // 
            this.labelNum3.AutoSize = true;
            this.labelNum3.Location = new System.Drawing.Point(13, 108);
            this.labelNum3.Name = "labelNum3";
            this.labelNum3.Size = new System.Drawing.Size(86, 13);
            this.labelNum3.TabIndex = 4;
            this.labelNum3.Text = "Terceiro Número";
            // 
            // textBoxNum3
            // 
            this.textBoxNum3.Location = new System.Drawing.Point(103, 105);
            this.textBoxNum3.Name = "textBoxNum3";
            this.textBoxNum3.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum3.TabIndex = 5;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.AutoSize = true;
            this.buttonCalcular.Location = new System.Drawing.Point(103, 178);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(160, 23);
            this.buttonCalcular.TabIndex = 6;
            this.buttonCalcular.Text = "Calcular Soma dos Quadrados";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(103, 239);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(187, 13);
            this.labelResultado.TabIndex = 7;
            this.labelResultado.Text = "Clique no botão para exibir o resultado";
            // 
            // FormSomaQuad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxNum3);
            this.Controls.Add(this.labelNum3);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Controls.Add(this.labelNum1);
            this.Name = "FormSomaQuad";
            this.Text = "Calcular Soma dos Quadrados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.Label labelNum3;
        private System.Windows.Forms.TextBox textBoxNum3;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelResultado;
    }
}

