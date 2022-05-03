using eAgenda_2._0.Dominio.ModuloCompromisso;
using eAgenda_2._0.Infra.Arquivos.RepositoriosEmArquivos;
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
    public partial class ListagemCompromissos : Form
    {
        private IRepositorioCompromisso repositorioCompromisso;

        public ListagemCompromissos()
        {
            SerializadorCompromissosJson serializadorCompromissos = new SerializadorCompromissosJson();
            repositorioCompromisso = new RepositorioCompromissoEmArquivo(serializadorCompromissos);

            InitializeComponent();
            CarregarCompromissos();
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            listCompromissosFuturos.Items.Clear();
            foreach (Compromisso compromissoFuturo in compromissos)
            {
                if(compromissoFuturo.DataCompromisso > DateTime.Now)
                    listCompromissosFuturos.Items.Add(compromissoFuturo);
            }

            listCompromissosPassados.Items.Clear();
            foreach (Compromisso compromissoPassado in compromissos)
            {
                if (compromissoPassado.DataCompromisso < DateTime.Now)
                {
                    //compromissoPassado.Contato.Compromisso = null;
                    listCompromissosPassados.Items.Add(compromissoPassado);
                }
            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroCompromissos tela = new CadastroCompromissos();
            tela.Compromisso = new Compromisso();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Inserir(tela.Compromisso);
                CarregarCompromissos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listCompromissosFuturos.SelectedItem;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro", "Edição de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroCompromissos tela = new CadastroCompromissos();

            tela.Compromisso = compromissoSelecionado;
            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Editar(tela.Compromisso);
                CarregarCompromissos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listCompromissosFuturos.SelectedItem;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro", "Edição de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o compromisso?",
                "Exclusão de Compromissos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromissoSelecionado);
                CarregarCompromissos();
            }
        }

        private void btnListarPeriodo_Click(object sender, EventArgs e)
        {
            ListarPorPeriodo tela = new ListarPorPeriodo();
            tela.ShowDialog();
        }

        private void listCompromissosFuturos_MouseHover(object sender, EventArgs e)
        {
            toolTip1.InitialDelay = 2000;
            toolTip1.ReshowDelay = 4000;
            toolTip1.SetToolTip(listCompromissosFuturos, "Duplo clique para detalhes do compromisso");
        }

        private void listCompromissosFuturos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listCompromissosFuturos.SelectedItem;

            DetalhesCompromisso tela = new DetalhesCompromisso(compromissoSelecionado);
            tela.Compromisso = compromissoSelecionado;
            tela.ShowDialog();
        }
    }
}
