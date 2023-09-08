namespace Atividade1
{
    public partial class FrmExercicio1 : Form
    {
        public FrmExercicio1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            string inputValue = txtBoxIdade.Text;

            if (!int.TryParse(inputValue, out _)) // Se não conseguir converter para int
            {
                MessageBox.Show("Por favor, insira somente números inteiros.");
                txtBoxIdade.Focus(); // Retorna o foco para a TextBox para correção
            }

            int idadeEmAnos = int.Parse(txtBoxIdade.Text);

            int idadeEmDias = (int)(idadeEmAnos * 365.25);

            lblIdadeConvertida.Text = idadeEmAnos.ToString() +
                " anos é equivalente à " + idadeEmDias.ToString() + " dias.";
        }
    }
}
