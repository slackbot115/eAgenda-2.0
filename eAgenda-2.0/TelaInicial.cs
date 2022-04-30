using eAgenda_2._0.Dominio;
using eAgenda_2._0.Infra.Arquivos;
using eAgenda_2._0.TelasContato;
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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            ListagemTarefas listagemTarefas = new ListagemTarefas();
            listagemTarefas.ShowDialog();
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            ListagemContatos listagemContatos = new ListagemContatos();
            listagemContatos.ShowDialog();
        }
    }
}
