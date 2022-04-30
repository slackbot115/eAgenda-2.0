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
    public partial class AtualizacaoItensTarefa : Form
    {
        private readonly Tarefa tarefa;

        public AtualizacaoItensTarefa(Tarefa tarefa)
        {
            InitializeComponent();
            this.tarefa = tarefa;

            labelTituloTarefa.Text = tarefa.Titulo;

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

        public List<ItemTarefa> ItensConcluidos
        {
            get
            {
                return listItensTarefa.CheckedItems
                    .Cast<ItemTarefa>()
                    .ToList();
            }
        }

        public List<ItemTarefa> ItensPendentes
        {
            get
            {                
                return listItensTarefa.Items
                    .Cast<ItemTarefa>()
                    .Except(ItensConcluidos)
                    .ToList();
            }
        }

        private void AtualizacaoItensTarefa_Load(object sender, EventArgs e)
        {
            pbarCompletude.Value = (int)tarefa.CalcularPercentualConcluido();
        }
    }
}
