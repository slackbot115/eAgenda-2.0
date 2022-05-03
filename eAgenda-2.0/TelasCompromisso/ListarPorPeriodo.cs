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
    public partial class ListarPorPeriodo : Form
    {
        private IRepositorioCompromisso repositorioCompromisso;
        private List<Compromisso> compromissos;

        public ListarPorPeriodo()
        {
            SerializadorCompromissosJson serializadorCompromissos = new SerializadorCompromissosJson();
            repositorioCompromisso = new RepositorioCompromissoEmArquivo(serializadorCompromissos);

            compromissos = repositorioCompromisso.SelecionarTodos();

            InitializeComponent();
        }

        private void CarregarDatasDoPeriodo()
        {
            if (dateDataInicial.Value > dateDataFinal.Value)
            {
                MessageBox.Show("Data de início maior que a data final da busca", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listDatasDoPeriodo.Items.Clear();

            foreach (Compromisso compromisso in compromissos)
            {
                if (compromisso.DataCompromisso > dateDataInicial.Value && compromisso.DataCompromisso < dateDataFinal.Value)
                {
                    listDatasDoPeriodo.Items.Add(compromisso);
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CarregarDatasDoPeriodo();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
