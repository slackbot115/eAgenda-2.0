using eAgenda_2._0.Dominio;
using eAgenda_2._0.Infra.Arquivos;
using eAgenda_2._0.TelasTarefa;
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
    public partial class ListagemTarefas : Form
    {
        private IRepositorioTarefa repositorioTarefa;

        public ListagemTarefas()
        {
            SerializadorTarefasJson serializadorTarefas = new SerializadorTarefasJson();
            repositorioTarefa = new RepositorioTarefaEmArquivo(serializadorTarefas);

            InitializeComponent();
            CarregarTarefas();
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefasConcluidas = repositorioTarefa.SelecionarTarefasConcluidas();

            listTarefasConcluidas.Items.Clear();

            foreach (Tarefa tarefa in tarefasConcluidas)
            {
                listTarefasConcluidas.Items.Add(tarefa);
            }

            // Exibindo tarefas pendentes por prioridade
            List<Tarefa> tarefasPendentes = repositorioTarefa.SelecionarTarefasPendentes();

            listTarefasPendentes.Items.Clear();

            foreach (Tarefa tarefa in tarefasPendentes)
            {
                if (tarefa.Prioridade == "Alta")
                {
                    listTarefasPendentes.Items.Add(tarefa);
                }
            }

            foreach (Tarefa tarefa in tarefasPendentes)
            {
                if (tarefa.Prioridade == "Média")
                {
                    listTarefasPendentes.Items.Add(tarefa);
                }
            }

            foreach (Tarefa tarefa in tarefasPendentes)
            {
                if (tarefa.Prioridade == "Baixa")
                {
                    listTarefasPendentes.Items.Add(tarefa);
                }
            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroTarefas tela = new CadastroTarefas();
            tela.Tarefa = new Tarefa();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Inserir(tela.Tarefa);
                CarregarTarefas();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroTarefas tela = new CadastroTarefas();

            tela.Tarefa = tarefaSelecionada;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Editar(tela.Tarefa);
                CarregarTarefas();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasConcluidas.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Só é possivel excluir uma tarefa concluída",
                "Exclusão de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a tarefa?",
                "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefaSelecionada);
                CarregarTarefas();
            }
        }

        private void btnCadastrarItens_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroItensTarefa tela = new CadastroItensTarefa(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itens = tela.ItensAdicionados;

                repositorioTarefa.AdicionarItens(tarefaSelecionada, itens);

                CarregarTarefas();
            }
        }

        private void btnAtualizarItens_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            AtualizacaoItensTarefa tela = new AtualizacaoItensTarefa(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itensConcluidos = tela.ItensConcluidos;

                List<ItemTarefa> itensPendentes = tela.ItensPendentes;

                repositorioTarefa.AtualizarItens(tarefaSelecionada, itensConcluidos, itensPendentes);
                CarregarTarefas();
            }
        }

        private void listTarefasPendentes_DrawItem(object sender, DrawItemEventArgs e)
        {
            Tarefa? tarefaExibida = (Tarefa) listTarefasPendentes.Items[e.Index];

            e.DrawBackground();
            Brush corLinha = Brushes.Black;

            if (tarefaExibida.Prioridade == "Alta")
            {
                corLinha = Brushes.Red;
            }
            else if(tarefaExibida.Prioridade == "Média")
            {
                corLinha = Brushes.DarkOrange;
            }
            else
            {
                corLinha = Brushes.Green;
            }

            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                e.Font, corLinha, e.Bounds, StringFormat.GenericDefault);

            e.DrawFocusRectangle();
        }

        private void listTarefasPendentes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;
            
            DetalhesTarefa tela = new DetalhesTarefa(tarefaSelecionada);
            tela.Tarefa = tarefaSelecionada;
            tela.ShowDialog();
        }
        
        private void listTarefasPendentes_MouseHover(object sender, EventArgs e)
        {
            toolTip1.InitialDelay = 2000;
            toolTip1.ReshowDelay = 4000;
            toolTip1.SetToolTip(listTarefasPendentes, "Duplo clique para detalhes da tarefa");
        }
    }
}
