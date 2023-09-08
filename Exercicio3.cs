namespace Atividade1
{
    public partial class FrmExercicio3 : Form
    {
        private const int MaxAlunos = 10;
        private int contadorAlunos = 0;
        private int aprovados = 0;
        private int emExames = 0;
        private int reprovados = 0;
        private double somaNotas = 0;

        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void btnCalucular_Click_1(object sender, EventArgs e)
        {
            if (contadorAlunos < MaxAlunos)
            {
                string nomeAluno = txtNome.Text;
                double nota1, nota2;

                if (double.TryParse(txtNota1.Text, out nota1) && double.TryParse(txtNota2.Text, out nota2))
                {
                    double media = (nota1 + nota2) / 2;
                    somaNotas += media;

                    if (media >= 7.0)
                    {
                        aprovados++;
                    }
                    else if (media >= 4.0)
                    {
                        emExames++;
                    }
                    else
                    {
                        reprovados++;
                    }

                    contadorAlunos++;

                    lblMediaClasse.Text = $"Média Total da Classe: " +
                        $"{somaNotas / contadorAlunos:F2}";
                    lblQtAprovados.Text = $"Aprovados: {aprovados}";
                    lblQtExames.Text = $"Em Exames: {emExames}";
                    lblQtReprovados.Text = $"Reprovados: {reprovados}";

                    // Limpar campos para o próximo aluno
                    txtNome.Clear();
                    txtNota1.Clear();
                    txtNota2.Clear();
                    txtNome.Focus();

                    if (contadorAlunos >= MaxAlunos)
                    {
                        btnCalucular.Enabled = false;
                        MessageBox.Show("Limite de alunos atingido (10 alunos).");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira notas válidas.");
                }
            }
        }
    }
}

