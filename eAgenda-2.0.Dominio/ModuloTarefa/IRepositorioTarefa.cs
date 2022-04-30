using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda_2._0.Dominio
{
    public interface IRepositorioTarefa
    {
        void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens);
        void AtualizarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itensConcluidos, List<ItemTarefa> itensPendentes);
        void Editar(Tarefa tarefa);
        void Excluir(Tarefa tarefa);
        void Inserir(Tarefa novaTarefa);
        List<Tarefa> SelecionarTodos();

        List<Tarefa> SelecionarTarefasConcluidas();

        List<Tarefa> SelecionarTarefasPendentes();
    }
}
