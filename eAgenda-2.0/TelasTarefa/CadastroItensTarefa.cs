using eAgenda_2._0.Dominio;
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
    public partial class CadastroItensTarefa : Form
    {
        private readonly Tarefa tarefa;

        public CadastroItensTarefa(Tarefa tarefa)
        {
            InitializeComponent();
            
            this.tarefa = tarefa;

            labelTituloTarefa.Text = tarefa.Titulo;

            foreach (ItemTarefa item in tarefa.Itens)
            {
                listItensTarefa.Items.Add(item);
            }            
        }

        public List<ItemTarefa> ItensAdicionados 
        {
            get 
            {
                return listItensTarefa.Items.Cast<ItemTarefa>().ToList();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {            
            List<string> titulos = ItensAdicionados.Select(x => x.Titulo).ToList();

            if (VerificarCamposVazios())
            {
                if (VerificarCamposDuplicados())
                {
                    if (titulos.Count == 0 || titulos.Contains(txtTituloItem.Text) == false)
                    {
                        ItemTarefa itemTarefa = new ItemTarefa();

                        itemTarefa.Titulo = txtTituloItem.Text;

                        listItensTarefa.Items.Add(itemTarefa);

                        txtTituloItem.Text = String.Empty;
                    }
                }
                else
                {
                    var resultado = MessageBox.Show("Título do ítem já existe nesta tarefa, tente novamente", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Cancel)
                        DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                var resultado = MessageBox.Show("Título do ítem vazio, tente novamente", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Cancel)
                    DialogResult = DialogResult.Cancel;
            }
        }

        private void CadastroItensTarefa_Load(object sender, EventArgs e)
        {
            pbarCompletude.Value = (int)tarefa.CalcularPercentualConcluido();
        }

        private bool VerificarCamposVazios()
        {
            if (String.IsNullOrEmpty(txtTituloItem.Text))
            {
                return false;
            }
            else
                return true;
        }

        private bool VerificarCamposDuplicados()
        {
            foreach (ItemTarefa item in ItensAdicionados)
            {
                if (txtTituloItem.Text == item.Titulo)
                    return false;
            }

            return true;
        }

    }
}
