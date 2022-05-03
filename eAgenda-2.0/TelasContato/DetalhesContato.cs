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
    public partial class DetalhesContato : Form
    {
        private Contato contato;

        public DetalhesContato(Contato contato)
        {
            this.contato = contato;

            InitializeComponent();
        }

        public Contato Contato
        {
            get { return contato; }
            set
            {
                contato = value;
                txtNumero.Text = contato.Numero.ToString();
                txtNome.Text = contato.Nome;
                txtEmail.Text = contato.Email;
                maskTelefone.Text = contato.Telefone;
                txtEmpresa.Text = contato.Empresa;
                txtCargo.Text = contato.Cargo;
            }
        }

    }
}
