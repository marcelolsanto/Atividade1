namespace Atividade1
{
    partial class FrmExercicio2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtSalario = new TextBox();
            txtQntFilhos = new TextBox();
            btnInserirNaLista = new Button();
            lblMediaSalarios = new Label();
            lblMediaNumFilhos = new Label();
            lblMaiorSalario = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 57);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Salário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 104);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 2;
            label3.Text = "Número de Filhos:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(70, 8);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(341, 27);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(70, 52);
            txtSalario.Margin = new Padding(3, 4, 3, 4);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(341, 27);
            txtSalario.TabIndex = 4;
            // 
            // txtQntFilhos
            // 
            txtQntFilhos.Location = new Point(149, 97);
            txtQntFilhos.Margin = new Padding(3, 4, 3, 4);
            txtQntFilhos.Name = "txtQntFilhos";
            txtQntFilhos.Size = new Size(262, 27);
            txtQntFilhos.TabIndex = 5;
            // 
            // btnInserirNaLista
            // 
            btnInserirNaLista.Location = new Point(14, 143);
            btnInserirNaLista.Margin = new Padding(3, 4, 3, 4);
            btnInserirNaLista.Name = "btnInserirNaLista";
            btnInserirNaLista.Size = new Size(397, 31);
            btnInserirNaLista.TabIndex = 6;
            btnInserirNaLista.Text = "Exibir";
            btnInserirNaLista.UseVisualStyleBackColor = true;
            btnInserirNaLista.Click += btnInserirNaLista_Click;
            // 
            // lblMediaSalarios
            // 
            lblMediaSalarios.AutoSize = true;
            lblMediaSalarios.Location = new Point(14, 197);
            lblMediaSalarios.Name = "lblMediaSalarios";
            lblMediaSalarios.Size = new Size(0, 20);
            lblMediaSalarios.TabIndex = 7;
            // 
            // lblMediaNumFilhos
            // 
            lblMediaNumFilhos.AutoSize = true;
            lblMediaNumFilhos.Location = new Point(14, 234);
            lblMediaNumFilhos.Name = "lblMediaNumFilhos";
            lblMediaNumFilhos.Size = new Size(0, 20);
            lblMediaNumFilhos.TabIndex = 8;
            // 
            // lblMaiorSalario
            // 
            lblMaiorSalario.AutoSize = true;
            lblMaiorSalario.Location = new Point(14, 274);
            lblMaiorSalario.Name = "lblMaiorSalario";
            lblMaiorSalario.Size = new Size(0, 20);
            lblMaiorSalario.TabIndex = 9;
            // 
            // FrmExercicio2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 317);
            Controls.Add(lblMaiorSalario);
            Controls.Add(lblMediaNumFilhos);
            Controls.Add(lblMediaSalarios);
            Controls.Add(btnInserirNaLista);
            Controls.Add(txtQntFilhos);
            Controls.Add(txtSalario);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmExercicio2";
            Text = "Exercicio2";
            Load += FrmExercicio2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtSalario;
        private TextBox txtQntFilhos;
        private Button btnInserirNaLista;
        private Label lblMediaSalarios;
        private Label lblMediaNumFilhos;
        private Label lblMaiorSalario;
    }
}