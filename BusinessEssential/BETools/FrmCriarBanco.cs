using BasesBE;
using BETools.CRUDBanco;
using DBBE;
using System.Text;

namespace BETools
{
    public partial class FrmCriarBanco : Form
    {
        public FrmCriarBanco()
        {
            InitializeComponent();
        }
        Login login;
        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                txtCNPJ.Text = "67587925000137";
                txtNomeBanco.Text = "Empresa";
                txtRSocial.Text = "Empresa";
                txtUsuario.Text = "Empresa";
                txtSenha.Text = "1234";

                CriarBaseDeDados deDados = new CriarBaseDeDados();
                deDados.NomeDataBase = txtNomeBanco.Text;
                deDados.CNPJ = BasesBE.FormatCNPJCPF.SemFormatacao(txtCNPJ.Text);                
                deDados.NomeEmpresa = BasesBE.FormatCNPJCPF.SemFormatacao(txtRSocial.Text); 
                deDados.NomeUsuario = BasesBE.FormatCNPJCPF.SemFormatacao(txtUserName.Text); 
                deDados.Senha = BasesBE.Criptografia.Criptografar(txtSenha.Text) ;
                deDados.CriarBase();
                MessageBox.Show("Banco de dados Criado");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if(BasesBE.FormatCNPJCPF.SemFormatacao(((TextBox)sender).Text).Length != 14)
            {
                MessageBox.Show("CNPJ INVALIDO");
            }
            else
            {
                ((TextBox)sender).Text = BasesBE.FormatCNPJCPF.FormatCNPJ(((TextBox)sender).Text);
            }
        }
    }
}