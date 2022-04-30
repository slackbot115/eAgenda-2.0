using eAgenda_2._0.Dominio;
using eAgenda_2._0.Dominio.ModuloTarefa;
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

        public CadastroTarefas()
        {
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
            }
        }      

        private void btnGravar_Click(object sender, EventArgs e)
        {            
            tarefa.Titulo = txtTitulo.Text;
            tarefa.Prioridade = comboPrioridade.Text;
        }
    }
}
