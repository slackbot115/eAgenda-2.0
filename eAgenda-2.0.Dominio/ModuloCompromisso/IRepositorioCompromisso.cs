using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda_2._0.Dominio.ModuloCompromisso
{
    public interface IRepositorioCompromisso
    {
        void Editar(Compromisso compromisso);
        void Excluir(Compromisso compromisso);
        void Inserir(Compromisso novoCompromisso);
        List<Compromisso> SelecionarTodos();
    }
}
