using CadastroCriptografado.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCriptografado.Forms
{
    public partial class frmLogin : Form
    {
        Usuario usuario = new Usuario();
        Simetrica Simetrica = new Simetrica();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCriarlogin_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
        }

        private void btnLoginAssimetrico_Click(object sender, EventArgs e)
        {
            try
            {

                usuario = usuario.retornaUsuario(txbEmail.Text);

                if (usuario != null)
                {


                    string senhaDescriptografada = Simetrica.DecryptData(usuario.Senha, "1234");

                    if (txbEmail.Text == usuario.Email && txbSenha.Text == senhaDescriptografada)
                    {
                        textBox2.Text = usuario.Email;
                        txbNome.Text = usuario.Nome;
                        textBox1.Text = usuario.Senha;
                        MessageBox.Show("Logado com sucesso!");
                        txbEmail.Text = "";
                        txbSenha.Text = "";

                    }

                }
                else
                {
                    txbEmail.Text = "";
                    txbSenha.Text = "";
                    MessageBox.Show("Usuario não cadastrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Erro ao Logado!");
            }




        }
    }
}
