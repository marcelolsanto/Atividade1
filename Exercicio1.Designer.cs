namespace Atividade1
{
    partial class FrmExercicio1
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
            lblIdade = new Label();
            txtBoxIdade = new TextBox();
            btnConverter = new Button();
            lblIdadeConvertida = new Label();
            SuspendLayout();
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(14, 16);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(121, 20);
            lblIdade.TabIndex = 0;
            lblIdade.Text = "Digite sua idade:";
            // 
            // txtBoxIdade
            // 
            txtBoxIdade.Location = new Point(128, 12);
            txtBoxIdade.Margin = new Padding(3, 4, 3, 4);
            txtBoxIdade.Name = "txtBoxIdade";
            txtBoxIdade.Size = new Size(41, 27);
            txtBoxIdade.TabIndex = 1;

            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(176, 12);
            btnConverter.Margin = new Padding(3, 4, 3, 4);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(142, 31);
            btnConverter.TabIndex = 2;
            btnConverter.Text = "Converter em dias";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // lblIdadeConvertida
            // 
            lblIdadeConvertida.BackColor = SystemColors.ActiveCaption;
            lblIdadeConvertida.BorderStyle = BorderStyle.Fixed3D;
            lblIdadeConvertida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdadeConvertida.Location = new Point(14, 55);
            lblIdadeConvertida.Name = "lblIdadeConvertida";
            lblIdadeConvertida.Size = new Size(304, 36);
            lblIdadeConvertida.TabIndex = 3;
            lblIdadeConvertida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmExercicio1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 104);
            Controls.Add(lblIdadeConvertida);
            Controls.Add(btnConverter);
            Controls.Add(txtBoxIdade);
            Controls.Add(lblIdade);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmExercicio1";
            Text = "Exercício 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdade;
        private TextBox txtBoxIdade;
        private Button btnConverter;
        private Label lblIdadeConvertida;
        private EventHandler txtBoxIdade_TextChanged;
    }
}