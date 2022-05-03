using eAgenda_2._0.Dominio.ModuloCompromisso;
using eAgenda_2._0.Dominio.ModuloContato;
using eAgenda_2._0.Infra.Arquivos;
using eAgenda_2._0.Infra.Arquivos.SerializacaoJson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda_2._0.TelasCompromisso
{
    public partial class CadastroCompromissos : Form
    {
        private Compromisso compromisso;

        private IRepositorioContato repositorioContato;
        private List<Contato> contatos;

        public CadastroCompromissos()
        {
            SerializadorContatosJson serializadorContatos = new SerializadorContatosJson();
            repositorioContato = new RepositorioContatoEmArquivo(serializadorContatos);

            contatos = repositorioContato.SelecionarTodos();

            InitializeComponent();

            dateHoraInicio.Format = DateTimePickerFormat.Custom;
            dateHoraInicio.CustomFormat = "HH:mm";
            dateHoraInicio.ShowUpDown = true;
            dateHoraTermino.Format = DateTimePickerFormat.Custom;
            dateHoraTermino.CustomFormat = "HH:mm";
            dateHoraTermino.ShowUpDown = true;
        }

        public Compromisso Compromisso { 
            get => compromisso;
            set { 
                compromisso = value;
                txtNumero.Text = compromisso.Numero.ToString();
                txtAssunto.Text = compromisso.Assunto;
                txtLocal.Text = compromisso.Local;
                if (compromisso.DataCompromisso < dateDataCompromisso.MinDate)
                {
                    dateDataCompromisso.Value = DateTime.Now;
                }
                else
                    dateDataCompromisso.Value = compromisso.DataCompromisso;
                dateHoraInicio.Text = compromisso.HoraInicio;
                dateHoraTermino.Text = compromisso.HoraTermino;
                if(!String.IsNullOrEmpty(comboContatos.Text))
                    comboContatos.Text = compromisso.Contato.Nome;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposVazios())
            {
                compromisso.Assunto = txtAssunto.Text;
                compromisso.Local = txtLocal.Text;

                if (ValidarDataCompromisso())
                {
                    compromisso.DataCompromisso = dateDataCompromisso.Value;

                    if (VerificarHorarioValido())
                    {
                        compromisso.HoraInicio = dateHoraInicio.Text;
                        compromisso.HoraTermino = dateHoraTermino.Text;

                        if (VerificarContatoVazio())
                        {
                            compromisso.Contato = ReceberContato(comboContatos.Text);
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            var resultado = MessageBox.Show("Contato inválido, tente novamente", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                            if (resultado == DialogResult.Cancel)
                                DialogResult = DialogResult.Cancel;
                        }
                    }
                    else
                    {
                        var resultado = MessageBox.Show("Horário inválido, tente novamente", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        if (resultado == DialogResult.Cancel)
                            DialogResult = DialogResult.Cancel;
                    }
                }
                else
                {
                    var resultado = MessageBox.Show("Data inválida, tente novamente", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
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

        private bool ValidarDataCompromisso()
        {
            if (dateDataCompromisso.Value > DateTime.Now)
            {
                return true;
            }
            else
                return false;
        }

        private bool VerificarHorarioValido()
        {
            if (dateHoraInicio.Value > dateHoraTermino.Value)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificarCamposVazios()
        {
            if (!String.IsNullOrEmpty(txtAssunto.Text) && !String.IsNullOrEmpty(txtLocal.Text) && !String.IsNullOrEmpty(dateDataCompromisso.Text))
            {
                return true;
            }
            else
                return false;
        }

        private void CadastroCompromissos_Load(object sender, EventArgs e)
        {
            foreach (Contato contato in contatos)
            {
                if (contato.EstaAnexado == false)
                    comboContatos.Items.Add(contato.Nome);
            }
        }

        private Contato? ReceberContato(string nome)
        {
            foreach (Contato contato in contatos)
            {
                if (contato.Nome == nome && contato.EstaAnexado == false)
                {
                    contato.EstaAnexado = true;
                    repositorioContato.Editar(contato);
                    return contato;
                }
            }

            return null;
        }

        private bool VerificarContatoVazio()
        {
            if (!String.IsNullOrEmpty(comboContatos.Text))
                return true;
            else
                return false;
        }
    }
}
