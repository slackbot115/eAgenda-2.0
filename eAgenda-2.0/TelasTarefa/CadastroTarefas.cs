using eAgenda_2._0.Dominio;
using eAgenda_2._0.Dominio.ModuloTarefa;
using eAgenda_2._0.Infra.Arquivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda_2._0
{
    public partial class CadastroTarefas : Form
    {
        private Tarefa tarefa;

        private IRepositorioTarefa repositorioTarefa;
        private List<Tarefa> tarefas;

        public CadastroTarefas()
        {
            SerializadorTarefasJson serializadorTarefas = new SerializadorTarefasJson();
            repositorioTarefa = new RepositorioTarefaEmArquivo(serializadorTarefas);

            tarefas = repositorioTarefa.SelecionarTodos();

            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
                txtNumero.Text = tarefa.Numero.ToString();
                txtTitulo.Text = tarefa.Titulo;
                comboPrioridade.Text = tarefa.Prioridade;
            }
        }      

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposVazios())
            {
                if (VerificarCamposDuplicados())
                {
                    tarefa.Titulo = txtTitulo.Text;

                    if (String.IsNullOrEmpty(comboPrioridade.Text))
                        comboPrioridade.Text = "Baixa";

                    tarefa.Prioridade = comboPrioridade.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    var resultado = MessageBox.Show("Já existe uma tarefa com esse título, digite outro", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Cancel)
                        DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                var resultado = MessageBox.Show("Título vazio, tente novamente", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Cancel)
                    DialogResult = DialogResult.Cancel;
            }
        }

        private bool VerificarCamposVazios()
        {
            if (String.IsNullOrEmpty(txtTitulo.Text))
            {
                return false;
            }
            else
                return true;
        }

        private bool VerificarCamposDuplicados()
        {
            foreach (Tarefa tarefa in tarefas)
            {
                if (txtTitulo.Text == tarefa.Titulo && txtNumero.Text == "0")
                    return false;
            }

            return true;
        }
    }
}
