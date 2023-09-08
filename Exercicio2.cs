namespace Atividade1
{
    public partial class FrmExercicio2 : Form
    {
        public FrmExercicio2()
        {
            InitializeComponent();
        }

        private List<string> nomes = new List<string>();
        private List<decimal> salarios = new List<decimal>();
        private List<decimal> numFilhosList = new List<decimal>();

        private void btnInserirNaLista_Click(object sender, EventArgs e)
        {
            // Coletar e validar o nome
            string nome = txtNome.Text;
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Por favor, insira um nome válido.");
                return;
            }
            nomes.Add(nome);

            // Coletar e validar o salário
            if (decimal.TryParse(txtSalario.Text, out decimal salario))
            {
                salarios.Add(salario);
                decimal mediaSalarios = salarios.Sum(s => s) / salarios.Count;
                lblMediaSalarios.Text = "Média dos Salários informados é de: "
                    + mediaSalarios.ToString("C");
                lblMaiorSalario.Text = "O maior salário informado dos habitantes é de: " +
                    salarios.Max().ToString("C");

            }
            else
            {
                MessageBox.Show("Salário inválido! Insira um número válido.");
                return;
            }

            // Coletar e validar o número de filhos
            if (decimal.TryParse(txtQntFilhos.Text, out decimal nFilhos))
            {
                numFilhosList.Add(nFilhos);
                decimal mediaNumFilhos = numFilhosList.Sum(s => s) / numFilhosList.Count;
                lblMediaNumFilhos.Text = "Média da quantidade de filhos informados é de: "
                    + mediaNumFilhos.ToString("F2");
            }
            else
            {
                MessageBox.Show("Número de filhos inválido! Insira um número inteiro válido.");
                return;
            }

            // Limpa as TextBoxes após a inserção
            txtNome.Clear();
            txtSalario.Clear();
            txtQntFilhos.Clear();
            txtNome.Focus();
        }

        private void FrmExercicio2_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
