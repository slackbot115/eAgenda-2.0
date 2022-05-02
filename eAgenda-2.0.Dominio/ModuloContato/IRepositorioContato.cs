using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda_2._0.Dominio.ModuloContato
{
    public interface IRepositorioContato
    {
        void Editar(Contato contato);
        void Excluir(Contato contato);
        void Inserir(Contato novoContato);
        List<Contato> SelecionarTodos();
        IEnumerable<IGrouping<string, Contato>> SelecionarContatosPorCargo();
    }
}
