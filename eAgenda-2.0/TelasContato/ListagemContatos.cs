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

namespace eAgenda_2._0.TelasContato
{
    public partial class ListagemContatos : Form
    {
        private IRepositorioContato repositorioContato;

        public ListagemContatos()
        {
            SerializadorContatosJson serializadorContatos = new SerializadorContatosJson();
            repositorioContato = new RepositorioContatoEmArquivo(serializadorContatos);

            InitializeComponent();
            CarregarContatos();
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listContatos.Items.Clear();

            foreach (Contato contato in contatos)
            {
                listContatos.Items.Add(contato);
            }

            IEnumerable<IGrouping<string, Contato>> contatosPorCargo =
                repositorioContato.SelecionarContatosPorCargo();

            listContatosOrdenados.Items.Clear();

            foreach (var cargos in contatosPorCargo)
            {
                if(String.IsNullOrEmpty(cargos.Key))
                    listContatosOrdenados.Items.Add("\nCargo não informado");
                else
                    listContatosOrdenados.Items.Add("\nCargo: " + cargos.Key);
                foreach (var contato in contatos)
                {
                    if (contato.Cargo == cargos.Key)
                    {
                        listContatosOrdenados.Items.Add(contato.ToString());
                    }
                }
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroContatos tela = new CadastroContatos();
            tela.Contato = new Contato();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Inserir(tela.Contato);
                CarregarContatos();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro", "Edição de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroContatos tela = new CadastroContatos();

            tela.Contato = contatoSelecionado;
            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Editar(tela.Contato);
                CarregarContatos();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro", "Exclusão de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (contatoSelecionado.EstaAnexado == true)
            {
                MessageBox.Show("Não é possível excluir um contato que está anexado à um compromisso aberto", "Exclusão de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o contato?",
                "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Excluir(contatoSelecionado);
                CarregarContatos();
            }
        }

        private void listContatos_MouseHover(object sender, EventArgs e)
        {
            toolTip1.InitialDelay = 2000;
            toolTip1.ReshowDelay = 4000;
            toolTip1.SetToolTip(listContatos, "Duplo clique para detalhes do contato");
        }

        private void listContatos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            DetalhesContato tela = new DetalhesContato(contatoSelecionado);
            tela.Contato = contatoSelecionado;
            tela.ShowDialog();
        }
    }
}
