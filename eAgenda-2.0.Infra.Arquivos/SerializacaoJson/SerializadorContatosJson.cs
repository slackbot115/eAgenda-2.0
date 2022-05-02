using eAgenda_2._0.Dominio.ModuloContato;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda_2._0.Infra.Arquivos.SerializacaoJson
{
    public class SerializadorContatosJson : ISerializadorContatos
    {
        private static string caminhoContatos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private string arquivoContatos = caminhoContatos + @"\contatos.json";

        public List<Contato> CarregarContatosDoArquivo()
        {
            if (!Directory.Exists(caminhoContatos))
            {
                Directory.CreateDirectory(caminhoContatos);
            }
            if (File.Exists(arquivoContatos) == false)
                return new List<Contato>();

            string contatosJson = File.ReadAllText(arquivoContatos);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            return JsonConvert.DeserializeObject<List<Contato>>(contatosJson, settings);
        }

        public void GravarContatosEmArquivo(List<Contato> contatos)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string contatosJson = JsonConvert.SerializeObject(contatos, settings);

            File.WriteAllText(arquivoContatos, contatosJson);
        }
    }
}
