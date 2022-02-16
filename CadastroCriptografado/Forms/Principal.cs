using CadastroCriptografado.Model;

namespace CadastroCriptografado
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            try
            {
                Simetrica simetrica = new Simetrica();
                Usuario usuario = new Usuario();
                usuario.Nome = txbNome.Text;
                usuario.Email = txbEmail.Text;

                string textoCripto = simetrica.EncryptData(txbSenha.Text,"1234");
                usuario.Senha = textoCripto;
                usuario.gravarLogim();
                txbEmail.Text = "";
                txbNome.Text = "";
                txbSenha.Text = "";
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro ao Cadastrar Usuario!");
            }
        }


    }
}