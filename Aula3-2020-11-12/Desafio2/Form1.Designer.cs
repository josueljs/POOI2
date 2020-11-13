namespace Desafio2
{
    partial class FormAntSuc
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
            this.labelNum = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelAntecessor = new System.Windows.Forms.Label();
            this.labelSucessor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(13, 13);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(44, 13);
            this.labelNum.TabIndex = 0;
            this.labelNum.Text = "Número";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(63, 10);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum.TabIndex = 1;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.AutoSize = true;
            this.buttonCalcular.Location = new System.Drawing.Point(63, 61);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(167, 23);
            this.buttonCalcular.TabIndex = 2;
            this.buttonCalcular.Text = "Calcular Antecessor e Sucessor";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelAntecessor
            // 
            this.labelAntecessor.AutoSize = true;
            this.labelAntecessor.Location = new System.Drawing.Point(63, 120);
            this.labelAntecessor.Name = "labelAntecessor";
            this.labelAntecessor.Size = new System.Drawing.Size(60, 13);
            this.labelAntecessor.TabIndex = 3;
            this.labelAntecessor.Text = "Antecessor";
            // 
            // labelSucessor
            // 
            this.labelSucessor.AutoSize = true;
            this.labelSucessor.Location = new System.Drawing.Point(63, 164);
            this.labelSucessor.Name = "labelSucessor";
            this.labelSucessor.Size = new System.Drawing.Size(51, 13);
            this.labelSucessor.TabIndex = 4;
            this.labelSucessor.Text = "Sucessor";
            // 
            // FormAntSuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelSucessor);
            this.Controls.Add(this.labelAntecessor);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.labelNum);
            this.Name = "FormAntSuc";
            this.Text = "Antecessor e Sucessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelAntecessor;
        private System.Windows.Forms.Label labelSucessor;
    }
}

