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

namespace eAgenda_2._0.TelasTarefa
{
    public partial class DetalhesTarefa : Form
    {
        private Tarefa tarefa;

        public DetalhesTarefa(Tarefa tarefa)
        {
            this.tarefa = tarefa;

            InitializeComponent();
            CarregarItensTarefa(tarefa);
        }

        private void CarregarItensTarefa(Tarefa tarefa)
        {
            int i = 0;
            foreach (var item in tarefa.Itens)
            {
                listItensTarefa.Items.Add(item);

                if (item.Concluido)
                    listItensTarefa.SetItemChecked(i, true);

                i++;
            }
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

        private void DetalhesTarefa_Load(object sender, EventArgs e)
        {
            pbarCompletude.Value = (int)tarefa.CalcularPercentualConcluido();
        }
    }
}
