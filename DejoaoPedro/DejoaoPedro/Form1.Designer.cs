namespace DejoaoPedro
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
            button_abrir = new Button();
            button_encriptar = new Button();
            button_desencriptar = new Button();
            button_salvar = new Button();
            textBoxConteudo = new TextBox();
            label1 = new Label();
            labelDeJoaoPedro = new Label();
            SuspendLayout();
            // 
            // button_abrir
            // 
            button_abrir.Location = new Point(68, 27);
            button_abrir.Name = "button_abrir";
            button_abrir.Size = new Size(75, 23);
            button_abrir.TabIndex = 0;
            button_abrir.Text = "Abrir";
            button_abrir.UseVisualStyleBackColor = true;
            button_abrir.Click += button_abrir_Click;
            // 
            // button_encriptar
            // 
            button_encriptar.Location = new Point(149, 27);
            button_encriptar.Name = "button_encriptar";
            button_encriptar.Size = new Size(75, 23);
            button_encriptar.TabIndex = 1;
            button_encriptar.Text = "Encriptar";
            button_encriptar.UseVisualStyleBackColor = true;
            button_encriptar.Click += button_encriptar_Click;
            // 
            // button_desencriptar
            // 
            button_desencriptar.Location = new Point(230, 27);
            button_desencriptar.Name = "button_desencriptar";
            button_desencriptar.Size = new Size(89, 23);
            button_desencriptar.TabIndex = 2;
            button_desencriptar.Text = "Desencriptar";
            button_desencriptar.UseVisualStyleBackColor = true;
            button_desencriptar.Click += button_desencriptar_Click;
            // 
            // button_salvar
            // 
            button_salvar.Location = new Point(325, 27);
            button_salvar.Name = "button_salvar";
            button_salvar.Size = new Size(75, 23);
            button_salvar.TabIndex = 3;
            button_salvar.Text = "Salvar";
            button_salvar.UseVisualStyleBackColor = true;
            button_salvar.Click += button_salvar_Click;
            // 
            // textBoxConteudo
            // 
            textBoxConteudo.Location = new Point(68, 56);
            textBoxConteudo.Multiline = true;
            textBoxConteudo.Name = "textBoxConteudo";
            textBoxConteudo.Size = new Size(472, 326);
            textBoxConteudo.TabIndex = 4;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // labelDeJoaoPedro
            // 
            labelDeJoaoPedro.AutoSize = true;
            labelDeJoaoPedro.Location = new Point(429, 31);
            labelDeJoaoPedro.Name = "labelDeJoaoPedro";
            labelDeJoaoPedro.Size = new Size(75, 15);
            labelDeJoaoPedro.TabIndex = 5;
            labelDeJoaoPedro.Text = "deJoaoPedro";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelDeJoaoPedro);
            Controls.Add(textBoxConteudo);
            Controls.Add(button_salvar);
            Controls.Add(button_desencriptar);
            Controls.Add(button_encriptar);
            Controls.Add(button_abrir);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_abrir;
        private Button button_encriptar;
        private Button button_desencriptar;
        private Button button_salvar;
        private TextBox textBoxConteudo;
        private Label label1;
        private Label labelDeJoaoPedro;
    }
}
