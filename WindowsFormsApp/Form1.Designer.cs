namespace WindowsFormsApp
{
    partial class Form1
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
            this.btnCadastrarNoticia = new System.Windows.Forms.Button();
            this.textBoxConteudo = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrarNoticia
            // 
            this.btnCadastrarNoticia.Location = new System.Drawing.Point(27, 136);
            this.btnCadastrarNoticia.Name = "btnCadastrarNoticia";
            this.btnCadastrarNoticia.Size = new System.Drawing.Size(150, 23);
            this.btnCadastrarNoticia.TabIndex = 0;
            this.btnCadastrarNoticia.Text = "Cadastrar Noticia";
            this.btnCadastrarNoticia.UseVisualStyleBackColor = true;
            this.btnCadastrarNoticia.Click += new System.EventHandler(this.btnCadastrarNoticia_Click);
            // 
            // textBoxConteudo
            // 
            this.textBoxConteudo.Location = new System.Drawing.Point(94, 80);
            this.textBoxConteudo.Name = "textBoxConteudo";
            this.textBoxConteudo.Size = new System.Drawing.Size(100, 20);
            this.textBoxConteudo.TabIndex = 1;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(94, 32);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitulo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Conteudo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 185);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.textBoxConteudo);
            this.Controls.Add(this.btnCadastrarNoticia);
            this.Name = "Form1";
            this.Text = "Notícias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarNoticia;
        private System.Windows.Forms.TextBox textBoxConteudo;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

