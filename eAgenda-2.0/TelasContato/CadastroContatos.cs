using eAgenda_2._0.Dominio.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda_2._0.TelasContato
{
    public partial class CadastroContatos : Form
    {
        private Contato contato;

        public CadastroContatos()
        {
            InitializeComponent();
        }

        public Contato Contato
        {
            get { return contato; }
            set { 
                contato = value;
                txtNumero.Text = contato.Numero.ToString();
                txtNome.Text = contato.Nome;
                txtEmail.Text = contato.Email;
                maskTelefone.Text = contato.Telefone;
                txtEmpresa.Text = contato.Empresa;
                txtCargo.Text = contato.Cargo;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposVazios())
            {
                contato.Nome = txtNome.Text;
                contato.Telefone = maskTelefone.Text;
                contato.Empresa = txtEmpresa.Text;
                contato.Cargo = txtCargo.Text;

                if (VerificarEmailValido())
                {
                    contato.Email = txtEmail.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    var resultado = MessageBox.Show("Email inválido, tente novamente", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Cancel)
                        DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                var resultado = MessageBox.Show("Campos obrigatórios(*) vazios, preencha-os", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Cancel)
                    DialogResult = DialogResult.Cancel;
            }
        }

        private bool VerificarEmailValido()
        {
            try
            {
                var email = new System.Net.Mail.MailAddress(txtEmail.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool VerificarCamposVazios()
        {
            if (!String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(txtEmail.Text) && maskTelefone.MaskCompleted)
            {
                return true;
            }
            else
                return false;
        }

    }
}
