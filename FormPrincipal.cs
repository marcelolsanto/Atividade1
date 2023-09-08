namespace Atividade1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuExercicio1_Click(object sender, EventArgs e)
        {
            FrmExercicio1 frmEditor = new FrmExercicio1();

            frmEditor.MdiParent = this;

            frmEditor.Show();
        }

        private void mnuExercicio2_Click(object sender, EventArgs e)
        {
            FrmExercicio2 frmEditor = new FrmExercicio2();

            frmEditor.MdiParent = this;

            frmEditor.Show();
        }

        private void mnuExercicio3_Click(object sender, EventArgs e)
        {
            FrmExercicio3 frmEditor = new FrmExercicio3();

            frmEditor.MdiParent = this;

            frmEditor.Show();

        }
    }
}