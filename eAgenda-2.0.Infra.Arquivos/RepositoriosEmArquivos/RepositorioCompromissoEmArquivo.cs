using eAgenda_2._0.Dominio.ModuloCompromisso;
using eAgenda_2._0.Infra.Arquivos.ISerializadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda_2._0.Infra.Arquivos.RepositoriosEmArquivos
{
    public class RepositorioCompromissoEmArquivo : IRepositorioCompromisso
    {
        private readonly ISerializadorCompromissos serializador;
        List<Compromisso> compromissos;
        private int contador = 0;

        public RepositorioCompromissoEmArquivo(ISerializadorCompromissos serializador)
        {
            this.serializador = serializador;

            compromissos = serializador.CarregarCompromissosDoArquivo();

            if (compromissos.Count > 0)
                contador = compromissos.Max(x => x.Numero);
        }

        public void Editar(Compromisso compromisso)
        {
            foreach (var item in compromissos)
            {
                if (item.Numero == compromisso.Numero)
                {
                    item.Assunto = compromisso.Assunto;
                    item.Local = compromisso.Local;
                    item.DataCompromisso = compromisso.DataCompromisso;
                    item.HoraInicio = compromisso.HoraInicio;
                    item.HoraTermino = compromisso.HoraTermino;
                    item.Contato = compromisso.Contato;
                    break;
                }
            }

            serializador.GravarCompromissosEmArquivo(compromissos);
        }

        public void Excluir(Compromisso compromisso)
        {
            compromissos.Remove(compromisso);

            serializador.GravarCompromissosEmArquivo(compromissos);
        }

        public void Inserir(Compromisso novoCompromisso)
        {
            novoCompromisso.Numero = ++contador;
            compromissos.Add(novoCompromisso);

            serializador.GravarCompromissosEmArquivo(compromissos);
        }

        public List<Compromisso> SelecionarTodos()
        {
            return compromissos;
        }
    }
}
