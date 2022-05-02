using eAgenda_2._0.Dominio.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda_2._0.Infra.Arquivos
{
    public class RepositorioContatoEmArquivo : IRepositorioContato
    {
        private readonly ISerializadorContatos serializador;
        List<Contato> contatos;
        private int contador = 0;

        public RepositorioContatoEmArquivo(ISerializadorContatos serializador)
        {
            this.serializador = serializador;

            contatos = serializador.CarregarContatosDoArquivo();

            if (contatos.Count > 0)
                contador = contatos.Max(x => x.Numero);
        }

        public List<Contato> SelecionarTodos()
        {
            return contatos;
        }

        public IEnumerable<IGrouping<string, Contato>> SelecionarContatosPorCargo()
        {
            return SelecionarTodos().GroupBy(x => x.Cargo);
        }

        public void Inserir(Contato novoContato)
        {
            novoContato.Numero = ++contador;
            contatos.Add(novoContato);

            serializador.GravarContatosEmArquivo(contatos);
        }

        public void Editar(Contato contato)
        {
            foreach (var item in contatos)
            {
                if (item.Numero == contato.Numero)
                {
                    item.Nome = contato.Nome;
                    item.Email = contato.Email;
                    item.Telefone = contato.Telefone;
                    item.Empresa = contato.Empresa;
                    item.Cargo = contato.Cargo;
                    item.EstaAnexado = contato.EstaAnexado;
                    break;
                }
            }

            serializador.GravarContatosEmArquivo(contatos);
        }

        public void Excluir(Contato contato)
        {
            contatos.Remove(contato);

            serializador.GravarContatosEmArquivo(contatos);
        }

    }
}
