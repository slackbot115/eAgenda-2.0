using eAgenda_2._0.Dominio.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda_2._0.Infra.Arquivos
{
    public interface ISerializadorContatos
    {
        List<Contato> CarregarContatosDoArquivo();
        void GravarContatosEmArquivo(List<Contato> contatos);
    }
}
