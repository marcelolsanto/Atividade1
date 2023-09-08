namespace Atividade1
{
    partial class FrmExercicio3
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
            labelNome = new Label();
            labelNota1 = new Label();
            labelNota2 = new Label();
            lblMediaClasse = new Label();
            btnCalucular = new Button();
            txtNome = new TextBox();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            lblQtAprovados = new Label();
            lblQtExames = new Label();
            lblQtReprovados = new Label();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(76, 55);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(53, 20);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome:";
            // 
            // labelNota1
            // 
            labelNota1.AutoSize = true;
            labelNota1.Location = new Point(76, 113);
            labelNota1.Name = "labelNota1";
            labelNota1.Size = new Size(57, 20);
            labelNota1.TabIndex = 1;
            labelNota1.Text = "Nota 1:";
            // 
            // labelNota2
            // 
            labelNota2.AutoSize = true;
            labelNota2.Location = new Point(322, 113);
            labelNota2.Name = "labelNota2";
            labelNota2.Size = new Size(57, 20);
            labelNota2.TabIndex = 2;
            labelNota2.Text = "Nota 2:";
            // 
            // lblMediaClasse
            // 
            lblMediaClasse.AutoSize = true;
            lblMediaClasse.Location = new Point(76, 228);
            lblMediaClasse.Name = "lblMediaClasse";
            lblMediaClasse.Size = new Size(120, 20);
            lblMediaClasse.TabIndex = 3;
            lblMediaClasse.Text = "Media da Classe:";
            // 
            // btnCalucular
            // 
            btnCalucular.Location = new Point(144, 163);
            btnCalucular.Name = "btnCalucular";
            btnCalucular.Size = new Size(366, 29);
            btnCalucular.TabIndex = 4;
            btnCalucular.Text = "Calcular";
            btnCalucular.UseVisualStyleBackColor = true;
            btnCalucular.Click += btnCalucular_Click_1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(144, 48);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(366, 27);
            txtNome.TabIndex = 5;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(144, 106);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(125, 27);
            txtNota1.TabIndex = 6;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(385, 110);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(125, 27);
            txtNota2.TabIndex = 7;
            // 
            // lblQtAprovados
            // 
            lblQtAprovados.AutoSize = true;
            lblQtAprovados.Location = new Point(76, 265);
            lblQtAprovados.Name = "lblQtAprovados";
            lblQtAprovados.Size = new Size(187, 20);
            lblQtAprovados.TabIndex = 8;
            lblQtAprovados.Text = "Quantidade de Aprovados:";
            // 
            // lblQtExames
            // 
            lblQtExames.AutoSize = true;
            lblQtExames.Location = new Point(76, 304);
            lblQtExames.Name = "lblQtExames";
            lblQtExames.Size = new Size(162, 20);
            lblQtExames.TabIndex = 9;
            lblQtExames.Text = "Quantidade de Exames";
            // 
            // lblQtReprovados
            // 
            lblQtReprovados.AutoSize = true;
            lblQtReprovados.Location = new Point(76, 339);
            lblQtReprovados.Name = "lblQtReprovados";
            lblQtReprovados.Size = new Size(194, 20);
            lblQtReprovados.TabIndex = 10;
            lblQtReprovados.Text = "Quantidade de Reprovados:";
            // 
            // FrmExercicio3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 450);
            Controls.Add(lblQtReprovados);
            Controls.Add(lblQtExames);
            Controls.Add(lblQtAprovados);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(txtNome);
            Controls.Add(btnCalucular);
            Controls.Add(lblMediaClasse);
            Controls.Add(labelNota2);
            Controls.Add(labelNota1);
            Controls.Add(labelNome);
            Name = "FrmExercicio3";
            Text = "Exercicio3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelNota1;
        private Label labelNota2;
        private Label lblMediaClasse;
        private Button btnCalucular;
        private TextBox txtNome;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private Label lblQtAprovados;
        private Label lblQtExames;
        private Label lblQtReprovados;
        private EventHandler btnCalucular_Click;
    }
}