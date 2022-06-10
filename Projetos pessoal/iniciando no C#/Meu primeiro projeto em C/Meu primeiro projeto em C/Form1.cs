namespace Meu_primeiro_projeto_em_C
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblmensagem.Text = "Primeiro Aplicativo em C#"; //A lblmensagem mostra uma mensagem
            lblmensagem.ForeColor = Color.RoyalBlue; //Muda a cor da Lblmensagem
        }

        private void btnpropriedadescheckbox_Click(object sender, EventArgs e)
        {
            Frmpropriedadescheckbox propriedades = new Frmpropriedadescheckbox();
            propriedades.ShowDialog();
        }
    }
}